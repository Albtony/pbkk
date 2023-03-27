namespace Contact_Database;
public partial class App : Application
{
    public static ContactRepository contactRepo { get; private set; }
    public App(ContactRepository repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        contactRepo = repo; 
    }
}
