namespace secureIt
{
    internal class TextDialog
    {
        #region Public Methods

        public static void Show(string text)
        {
            TextResultForm form = new TextResultForm();
            form.SetText(text);
            form.ShowDialog();
        }

        #endregion
    }
}
