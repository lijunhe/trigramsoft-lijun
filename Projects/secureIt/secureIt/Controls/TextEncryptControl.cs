using System;
using System.Windows.Forms;

using secureIt.Lib;

namespace secureIt.Controls
{
    public partial class TextEncryptControl : UserControl
    {
        public TextEncryptControl()
        {
            InitializeComponent();
        }

        #region Event Handlers 

        private void encryptCommandButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            string password = passwordTextBox.Text;

            //string encryptedText = AES.EncryptString(inputText, password);
            string encryptedText = "";

            //MessageBox.Show(encryptedText);
            TextDialog.Show(encryptedText);
        }

        #endregion
    }
}
