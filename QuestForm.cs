using System;
using System.Threading;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class QuestForm : Form
    {
        public static int length = 0;
        public static string[] result;

        public QuestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ChangesMade = false;

            //Quest 2 settings, might remove them in the future since some of them are broken
            if (RefreshRateComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.refreshRate {RefreshRateComboBox.SelectedItem.ToString()}");
                ADB.RunAdbCommandToString($"shell settings put global 90hz_global {RefreshRateComboBox.SelectedIndex}");
                ADB.RunAdbCommandToString($"shell settings put global 90hzglobal {RefreshRateComboBox.SelectedIndex}");
                ChangesMade = true;
            }

            if (TextureResTextBox.Text.Length > 0)
            {
                Int32.TryParse(TextureResTextBox.Text, out int result);
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureWidth {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureHeight {TextureResTextBox.Text}");
                ChangesMade = true;
            }

            if (CPUComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.cpuLevel {CPUComboBox.SelectedItem.ToString()}");
                ChangesMade = true;
            }

            if (GPUComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.gpuLevel {GPUComboBox.SelectedItem.ToString()}");
                ChangesMade = true;
            }

            if (ChangesMade)
                MessageBox.Show("Settings applied!");
        }



        public static void setLength(int value)
        {
            result = new string[value];
        }

        private async void button2_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Make sure your Quest is plugged in VIA USB then press OK.", "Connect Quest now.", MessageBoxButtons.OKCancel);
            ADB.RunAdbCommandToString("tcpip 5555");

            MessageBox.Show("Press OK to get your Quest's local IP address.", "Obtain local IP address", MessageBoxButtons.OKCancel);
            string input = ADB.RunAdbCommandToString("shell ip route").Output;
   
            {
                string[] strArrayOne = new string[] { "" };
                strArrayOne = input.Split(' ');
                if (strArrayOne[0].Length > 1)
                {
                    string IPaddr = strArrayOne[8];
                    string IPcmnd = "connect " + IPaddr + ":5555";
                    MessageBox.Show($"Your Quest's local IP address is: {IPaddr}\n\nPlease disconnect your Quest then wait 2 seconds.\nOnce it is disconnected hit OK", "", MessageBoxButtons.OK);
                    ADB.RunAdbCommandToString(IPcmnd);
                    await Program.form.CheckForDevice();
                    Program.form.ChangeTitlebarToDevice();
                    Program.form.showAvailableSpace();
                    Properties.Settings.Default.IPAddress = IPcmnd;
                    Properties.Settings.Default.Save();

                    MessageBox.Show($"Connected!!", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("No device connected!");
            }
        }

    }
}
