namespace secureIt.ViewModels
{
    public delegate void OperationContinueEventHandler(string inputSource, string action);

    public class OperationOptionsViewModel
    {
        #region Members

        #endregion

        #region Public Properties

        public string InputSource { get; set; }
        public string Action { get; set; }

        public event OperationContinueEventHandler OnContinue;

        #endregion

        #region Public Methods

        public void ContinueOperation()
        {
            if (this.OnContinue != null)
                this.OnContinue(this.InputSource, this.Action);
        }

        #endregion
    }
}
