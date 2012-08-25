using System;
using System.Windows.Forms;

using secureIt.Controls;
using secureIt.ViewModels;

namespace secureIt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadOperationOptionsPage();
        }

        private void OnOperationContinue(string inputSource, string action)
        {
            if (inputSource == "Password" && action == "Encrypt")
                LoadEncryptPage();

            if (inputSource == "Password" && action == "Decrypt")
                LoadDecryptPage();
        }

        #endregion

        #region Private Methods

        private void LoadOperationOptionsPage()
        {
            OperationOptionsViewModel viewModel = new OperationOptionsViewModel();
            viewModel.OnContinue += new OperationContinueEventHandler(OnOperationContinue);

            OperationOptionsControl control = new OperationOptionsControl();
            control.ViewModel = viewModel;

            this.contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void LoadEncryptPage()
        {
            TextEncryptControl control = new TextEncryptControl();

            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void LoadDecryptPage()
        {
            TextDecryptControl control = new TextDecryptControl();

            this.contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        #endregion
    }
}
