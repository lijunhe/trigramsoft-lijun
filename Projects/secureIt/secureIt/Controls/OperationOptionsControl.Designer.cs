namespace secureIt.Controls
{
    partial class OperationOptionsControl
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.SourceTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceFileRadioButton = new System.Windows.Forms.RadioButton();
            this.SourcePasswordRadioButton = new System.Windows.Forms.RadioButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.continueCommandButton = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.actionGroupBox.SuspendLayout();
            this.SourceTypeGroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.actionGroupBox);
            this.contentPanel.Controls.Add(this.SourceTypeGroupBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(513, 167);
            this.contentPanel.TabIndex = 0;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.decryptRadioButton);
            this.actionGroupBox.Controls.Add(this.encryptRadioButton);
            this.actionGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionGroupBox.Location = new System.Drawing.Point(110, 0);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Size = new System.Drawing.Size(110, 167);
            this.actionGroupBox.TabIndex = 3;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Text = "Action";
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(6, 54);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(62, 17);
            this.decryptRadioButton.TabIndex = 2;
            this.decryptRadioButton.TabStop = true;
            this.decryptRadioButton.Text = "Decrypt";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(6, 30);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(61, 17);
            this.encryptRadioButton.TabIndex = 1;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Encrypt";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // SourceTypeGroupBox
            // 
            this.SourceTypeGroupBox.Controls.Add(this.SourceFileRadioButton);
            this.SourceTypeGroupBox.Controls.Add(this.SourcePasswordRadioButton);
            this.SourceTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SourceTypeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SourceTypeGroupBox.Name = "SourceTypeGroupBox";
            this.SourceTypeGroupBox.Size = new System.Drawing.Size(110, 167);
            this.SourceTypeGroupBox.TabIndex = 2;
            this.SourceTypeGroupBox.TabStop = false;
            this.SourceTypeGroupBox.Text = "Source";
            // 
            // SourceFileRadioButton
            // 
            this.SourceFileRadioButton.AutoSize = true;
            this.SourceFileRadioButton.Location = new System.Drawing.Point(7, 54);
            this.SourceFileRadioButton.Name = "SourceFileRadioButton";
            this.SourceFileRadioButton.Size = new System.Drawing.Size(41, 17);
            this.SourceFileRadioButton.TabIndex = 1;
            this.SourceFileRadioButton.TabStop = true;
            this.SourceFileRadioButton.Text = "File";
            this.SourceFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // SourcePasswordRadioButton
            // 
            this.SourcePasswordRadioButton.AutoSize = true;
            this.SourcePasswordRadioButton.Checked = true;
            this.SourcePasswordRadioButton.Location = new System.Drawing.Point(7, 30);
            this.SourcePasswordRadioButton.Name = "SourcePasswordRadioButton";
            this.SourcePasswordRadioButton.Size = new System.Drawing.Size(71, 17);
            this.SourcePasswordRadioButton.TabIndex = 0;
            this.SourcePasswordRadioButton.TabStop = true;
            this.SourcePasswordRadioButton.Text = "Password";
            this.SourcePasswordRadioButton.UseVisualStyleBackColor = true;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.commandPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 167);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(513, 46);
            this.bottomPanel.TabIndex = 1;
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.continueCommandButton);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandPanel.Location = new System.Drawing.Point(405, 0);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(10);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(108, 46);
            this.commandPanel.TabIndex = 1;
            // 
            // continueCommandButton
            // 
            this.continueCommandButton.Location = new System.Drawing.Point(14, 13);
            this.continueCommandButton.Name = "continueCommandButton";
            this.continueCommandButton.Size = new System.Drawing.Size(75, 23);
            this.continueCommandButton.TabIndex = 0;
            this.continueCommandButton.Text = "Continue";
            this.continueCommandButton.UseVisualStyleBackColor = true;
            this.continueCommandButton.Click += new System.EventHandler(this.continueCommandButton_Click);
            // 
            // OperationOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "OperationOptionsControl";
            this.Size = new System.Drawing.Size(513, 213);
            this.contentPanel.ResumeLayout(false);
            this.actionGroupBox.ResumeLayout(false);
            this.actionGroupBox.PerformLayout();
            this.SourceTypeGroupBox.ResumeLayout(false);
            this.SourceTypeGroupBox.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.commandPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.GroupBox SourceTypeGroupBox;
        private System.Windows.Forms.RadioButton SourceFileRadioButton;
        private System.Windows.Forms.RadioButton SourcePasswordRadioButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Button continueCommandButton;

    }
}
