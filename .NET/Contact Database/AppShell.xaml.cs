using Contact_Database.Views;

namespace Contact_Database;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(InputPage), typeof(InputPage));
        Routing.RegisterRoute(nameof(ContactListPage), typeof(ContactListPage));
    }
}
