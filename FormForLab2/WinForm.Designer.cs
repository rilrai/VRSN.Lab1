namespace FormForLab2 {
    partial class WinForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.HtcButton = new System.Windows.Forms.RadioButton();
            this.SamsungButton = new System.Windows.Forms.RadioButton();
            this.XiaomiButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GameConsoleButton = new System.Windows.Forms.RadioButton();
            this.DynamicsButton = new System.Windows.Forms.RadioButton();
            this.ChargerButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HtcButton
            // 
            this.HtcButton.AccessibleName = "HtcButton";
            this.HtcButton.AutoSize = true;
            this.HtcButton.Checked = true;
            this.HtcButton.Location = new System.Drawing.Point(16, 12);
            this.HtcButton.Name = "HtcButton";
            this.HtcButton.Size = new System.Drawing.Size(85, 17);
            this.HtcButton.TabIndex = 1;
            this.HtcButton.TabStop = true;
            this.HtcButton.Text = "Htc Headset";
            this.HtcButton.UseVisualStyleBackColor = true;
            this.HtcButton.CheckedChanged += new System.EventHandler(this.HtcButton_CheckedChanged);
            // 
            // SamsungButton
            // 
            this.SamsungButton.AccessibleName = "SamsungButton";
            this.SamsungButton.AutoSize = true;
            this.SamsungButton.Location = new System.Drawing.Point(16, 35);
            this.SamsungButton.Name = "SamsungButton";
            this.SamsungButton.Size = new System.Drawing.Size(112, 17);
            this.SamsungButton.TabIndex = 2;
            this.SamsungButton.Text = "Samsung Headset";
            this.SamsungButton.UseVisualStyleBackColor = true;
            this.SamsungButton.CheckedChanged += new System.EventHandler(this.SamsungButton_CheckedChanged);
            // 
            // XiaomiButton
            // 
            this.XiaomiButton.AccessibleName = "XiaomiButton";
            this.XiaomiButton.AutoSize = true;
            this.XiaomiButton.Location = new System.Drawing.Point(16, 58);
            this.XiaomiButton.Name = "XiaomiButton";
            this.XiaomiButton.Size = new System.Drawing.Size(99, 17);
            this.XiaomiButton.TabIndex = 3;
            this.XiaomiButton.Text = "Xiaomi Headset";
            this.XiaomiButton.UseVisualStyleBackColor = true;
            this.XiaomiButton.CheckedChanged += new System.EventHandler(this.XiaomiButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 87);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select playback component and usb device";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HtcButton);
            this.panel1.Controls.Add(this.SamsungButton);
            this.panel1.Controls.Add(this.XiaomiButton);
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 91);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GameConsoleButton);
            this.panel2.Controls.Add(this.DynamicsButton);
            this.panel2.Controls.Add(this.ChargerButton);
            this.panel2.Location = new System.Drawing.Point(177, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 90);
            this.panel2.TabIndex = 8;
            // 
            // GameConsoleButton
            // 
            this.GameConsoleButton.AutoSize = true;
            this.GameConsoleButton.Location = new System.Drawing.Point(12, 58);
            this.GameConsoleButton.Name = "GameConsoleButton";
            this.GameConsoleButton.Size = new System.Drawing.Size(94, 17);
            this.GameConsoleButton.TabIndex = 2;
            this.GameConsoleButton.TabStop = true;
            this.GameConsoleButton.Text = "Game Console";
            this.GameConsoleButton.UseVisualStyleBackColor = true;
            this.GameConsoleButton.CheckedChanged += new System.EventHandler(this.GameConsoleButton_CheckedChanged);
            // 
            // DynamicsButton
            // 
            this.DynamicsButton.AutoSize = true;
            this.DynamicsButton.Location = new System.Drawing.Point(12, 35);
            this.DynamicsButton.Name = "DynamicsButton";
            this.DynamicsButton.Size = new System.Drawing.Size(71, 17);
            this.DynamicsButton.TabIndex = 1;
            this.DynamicsButton.TabStop = true;
            this.DynamicsButton.Text = "Dynamics";
            this.DynamicsButton.UseVisualStyleBackColor = true;
            this.DynamicsButton.CheckedChanged += new System.EventHandler(this.DynamicsButton_CheckedChanged);
            // 
            // ChargerButton
            // 
            this.ChargerButton.AutoSize = true;
            this.ChargerButton.Checked = true;
            this.ChargerButton.Location = new System.Drawing.Point(12, 12);
            this.ChargerButton.Name = "ChargerButton";
            this.ChargerButton.Size = new System.Drawing.Size(62, 17);
            this.ChargerButton.TabIndex = 0;
            this.ChargerButton.TabStop = true;
            this.ChargerButton.Text = "Charger";
            this.ChargerButton.UseVisualStyleBackColor = true;
            this.ChargerButton.CheckedChanged += new System.EventHandler(this.ChargerButton_CheckedChanged);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "WinForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton HtcButton;
        private System.Windows.Forms.RadioButton SamsungButton;
        private System.Windows.Forms.RadioButton XiaomiButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton GameConsoleButton;
        private System.Windows.Forms.RadioButton DynamicsButton;
        private System.Windows.Forms.RadioButton ChargerButton;
    }
}

