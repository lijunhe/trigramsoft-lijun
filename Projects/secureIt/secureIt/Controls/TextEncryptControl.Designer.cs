namespace secureIt.Controls
{
    partial class TextEncryptControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.encryptCommandButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.passwordTextBox);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(518, 40);
            this.topPanel.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(75, 11);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(226, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.encryptCommandButton);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandPanel.Location = new System.Drawing.Point(410, 0);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(10);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(108, 46);
            this.commandPanel.TabIndex = 1;
            // 
            // encryptCommandButton
            // 
            this.encryptCommandButton.Location = new System.Drawing.Point(14, 13);
            this.encryptCommandButton.Name = "encryptCommandButton";
            this.encryptCommandButton.Size = new System.Drawing.Size(75, 23);
            this.encryptCommandButton.TabIndex = 0;
            this.encryptCommandButton.Text = "&Encrypt";
            this.encryptCommandButton.UseVisualStyleBackColor = true;
            this.encryptCommandButton.Click += new System.EventHandler(this.encryptCommandButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.commandPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 143);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(518, 46);
            this.bottomPanel.TabIndex = 2;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.inputTextBox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(0, 40);
            this.textPanel.Margin = new System.Windows.Forms.Padding(10);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(518, 103);
            this.textPanel.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(518, 103);
            this.inputTextBox.TabIndex = 0;
            // 
            // TextEncryptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "TextEncryptControl";
            this.Size = new System.Drawing.Size(518, 189);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.commandPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button encryptCommandButton;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}
