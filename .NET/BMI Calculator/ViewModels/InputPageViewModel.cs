using BMI_Calculator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BMI_Calculator.ViewModels
{
    public partial class InputPageViewModel: ObservableObject
    {
        [RelayCommand]
        private async void saveContact()
        {
            await Shell.Current.GoToAsync(nameof(BMIListPage));
        }

        [RelayCommand]
        private async void ViewContacts()
        {
            await Shell.Current.GoToAsync(nameof(BMIListPage));
        }
    }
}
