namespace Lab3 {
    partial class MessageBox {
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
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.formattingBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 78);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(356, 263);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Text = "";
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // formattingBox
            // 
            this.formattingBox.FormattingEnabled = true;
            this.formattingBox.Location = new System.Drawing.Point(12, 35);
            this.formattingBox.Name = "formattingBox";
            this.formattingBox.Size = new System.Drawing.Size(206, 21);
            this.formattingBox.TabIndex = 1;
            this.formattingBox.SelectedIndexChanged += new System.EventHandler(this.formattingBox_SelectedIndexChanged);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 353);
            this.Controls.Add(this.formattingBox);
            this.Controls.Add(this.messageTextBox);
            this.Name = "MessageBox";
            this.Text = "MessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.ComboBox formattingBox;
    }
}