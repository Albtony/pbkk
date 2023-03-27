using Contact_Database.ViewModels;
namespace Contact_Database.Views;

public partial class InputPage : ContentPage
{
    public InputPage(InputPageViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
}