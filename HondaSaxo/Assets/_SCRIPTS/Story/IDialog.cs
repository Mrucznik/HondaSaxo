namespace Assets._SCRIPTS.Story
{
    public interface IDialog
    {
        void Display();
        IDialog GetNextDialog();
    }
}
