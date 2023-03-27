using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Contact_Database.ViewModels
{
    public partial class InputPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [RelayCommand]
        private async void SaveContact()
        {
            // TODO: Implement
        }

        [RelayCommand]
        private async void ViewContacts()
        {
            // TODO: Implement
        }
    }
}