using System;
using System.Windows.Forms;

using secureIt.Lib;

namespace secureIt.Controls
{
    public partial class TextDecryptControl : UserControl
    {
        public TextDecryptControl()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void decryptCommandButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            string password = passwordTextBox.Text;

            //string decryptedText = AES.DecryptString(inputText, password);
            string decryptedText = "";

            TextDialog.Show(decryptedText);
        }

        #endregion
    }
}
