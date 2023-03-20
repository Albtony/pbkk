using BMI_Calculator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BMI_Calculator.ViewModels
{
    public partial class InputPageViewModel: ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [RelayCommand]
        private async void Calculate()
        {
            await Shell.Current.GoToAsync($"{nameof(BMICalculatorPage)}?Text={Name}");
        }

        [RelayCommand]
        private async void ViewData()
        {
            await Shell.Current.GoToAsync(nameof(BMIListPage));
        }
    }
}
