using System;
using System.Threading;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class QuestForm : Form
    {
        public static int length = 0;
        public static string[] result;
        private readonly string executeString;

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

        private void button2_Click(object sender, EventArgs e)

        {

            string input = ADB.RunAdbCommandToString("shell ip route").Output;
            string lastWord = input.Substring(input.LastIndexOf('.') + 1);



            ADB.RunAdbCommandToString("tcpip 5555");
            DialogResult dialogResult = MessageBox.Show("Does your network IP address table start like this: 192.168.0.xxx, or 192.168.1.xxx? Answer YES for the former, NO for the latter.", "YES = 0, NO = 1", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ADB.RunAdbCommandToString($"connect 192.168.0.\" {lastWord}\":5555");
                MessageBox.Show("connect 192.168.0." + lastWord);
            }
            else
            {
                ADB.RunAdbCommandToString($"connect 192.168.1.\" {lastWord}\":5555");
                MessageBox.Show("connect 192.168.1." + lastWord + ":5555");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
