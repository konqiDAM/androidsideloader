﻿namespace AndroidSideloader
{
    partial class QuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            this.RefreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextureResTextBox = new System.Windows.Forms.TextBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.GPUComboBox = new System.Windows.Forms.ComboBox();
            this.CPUComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefreshRateComboBox
            // 
            this.RefreshRateComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RefreshRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshRateComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.RefreshRateComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.RefreshRateComboBox.FormattingEnabled = true;
            this.RefreshRateComboBox.Items.AddRange(new object[] {
            "72",
            "90"});
            this.RefreshRateComboBox.Location = new System.Drawing.Point(16, 15);
            this.RefreshRateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshRateComboBox.Name = "RefreshRateComboBox";
            this.RefreshRateComboBox.Size = new System.Drawing.Size(459, 26);
            this.RefreshRateComboBox.TabIndex = 0;
            this.RefreshRateComboBox.Text = "Select refresh rate";
            // 
            // button1
            // 
            this.button1.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.button1.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.button1.Location = new System.Drawing.Point(16, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextureResTextBox
            // 
            this.TextureResTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextureResTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.TextureResTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.TextureResTextBox.Location = new System.Drawing.Point(16, 133);
            this.TextureResTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextureResTextBox.Name = "TextureResTextBox";
            this.TextureResTextBox.Size = new System.Drawing.Size(159, 25);
            this.TextureResTextBox.TabIndex = 2;
            this.TextureResTextBox.Text = "0";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ResolutionLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ResolutionLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ResolutionLabel.Location = new System.Drawing.Point(180, 140);
            this.ResolutionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(240, 20);
            this.ResolutionLabel.TabIndex = 3;
            this.ResolutionLabel.Text = "Resolution per eye (0 for default)";
            // 
            // GPUComboBox
            // 
            this.GPUComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GPUComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPUComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.GPUComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.GPUComboBox.FormattingEnabled = true;
            this.GPUComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.GPUComboBox.Location = new System.Drawing.Point(16, 54);
            this.GPUComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.GPUComboBox.Name = "GPUComboBox";
            this.GPUComboBox.Size = new System.Drawing.Size(459, 26);
            this.GPUComboBox.TabIndex = 4;
            this.GPUComboBox.Text = "Select GPU level (0 for default)";
            // 
            // CPUComboBox
            // 
            this.CPUComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CPUComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.CPUComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.CPUComboBox.FormattingEnabled = true;
            this.CPUComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.CPUComboBox.Location = new System.Drawing.Point(16, 94);
            this.CPUComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUComboBox.Name = "CPUComboBox";
            this.CPUComboBox.Size = new System.Drawing.Size(459, 26);
            this.CPUComboBox.TabIndex = 5;
            this.CPUComboBox.Text = "Select CPU level (0 for default)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(167, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 85);
            this.button2.TabIndex = 7;
            this.button2.Text = "Connect to Wifi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(492, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUComboBox);
            this.Controls.Add(this.GPUComboBox);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.TextureResTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshRateComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(510, 2737);
            this.MinimumSize = new System.Drawing.Size(510, 265);
            this.Name = "QuestForm";
            this.ShowIcon = false;
            this.Text = "QuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RefreshRateComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextureResTextBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox GPUComboBox;
        private System.Windows.Forms.ComboBox CPUComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}