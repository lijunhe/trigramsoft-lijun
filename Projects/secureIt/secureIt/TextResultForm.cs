using System.Windows.Forms;

namespace secureIt
{
    public partial class TextResultForm : Form
    {
        public TextResultForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void closeCommandButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void SetText(string text)
        {
            this.inputTextBox.Text = text;
        }

        #endregion
    }
}
