namespace secureIt
{
    partial class TextResultForm
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.closeCommandButton = new System.Windows.Forms.Button();
            this.textPanel = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.bottomPanel.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.commandPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 170);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(560, 46);
            this.bottomPanel.TabIndex = 1;
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.closeCommandButton);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandPanel.Location = new System.Drawing.Point(452, 0);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(10);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(108, 46);
            this.commandPanel.TabIndex = 1;
            // 
            // closeCommandButton
            // 
            this.closeCommandButton.Location = new System.Drawing.Point(14, 13);
            this.closeCommandButton.Name = "closeCommandButton";
            this.closeCommandButton.Size = new System.Drawing.Size(75, 23);
            this.closeCommandButton.TabIndex = 0;
            this.closeCommandButton.Text = "Close";
            this.closeCommandButton.UseVisualStyleBackColor = true;
            this.closeCommandButton.Click += new System.EventHandler(this.closeCommandButton_Click);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.inputTextBox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(10);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(560, 170);
            this.textPanel.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(560, 170);
            this.inputTextBox.TabIndex = 0;
            // 
            // TextResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 216);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "TextResultForm";
            this.Text = "Result";
            this.bottomPanel.ResumeLayout(false);
            this.commandPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Button closeCommandButton;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}