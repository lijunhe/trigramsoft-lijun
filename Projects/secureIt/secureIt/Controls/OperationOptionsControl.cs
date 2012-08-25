using System;
using System.Windows.Forms;

using secureIt.ViewModels;

namespace secureIt.Controls
{
    public partial class OperationOptionsControl : UserControl
    {
        #region Public Properties

        public OperationOptionsViewModel ViewModel { get; set; }

        #endregion

        public OperationOptionsControl()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void continueCommandButton_Click(object sender, EventArgs e)
        {
            if (this.ViewModel != null)
            {
                this.ViewModel.InputSource = GetInputSource();
                this.ViewModel.Action = GetAction();
                this.ViewModel.ContinueOperation();
            }
        }

        #endregion

        #region Private Methods

        private string GetInputSource()
        {
            if (this.SourcePasswordRadioButton.Checked)
                return "Password";
            else
                return "File";
        }

        private string GetAction()
        {
            if (this.encryptRadioButton.Checked)
                return "Encrypt";
            else
                return "Decrypt";
        }

        #endregion
    }
}
