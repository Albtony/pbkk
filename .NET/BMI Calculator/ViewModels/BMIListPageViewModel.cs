using BMI_Calculator.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BMI_Calculator.ViewModels
{
    public partial class BMIListPageViewModel : ObservableObject
    {
        public ObservableCollection<BMIData> BMIList { get; } = new();

        [RelayCommand]
        public async void GetBMIList()
        {
            List<BMIData> BMIList = await App.BMIRepo.GetBMIList();
        }
    }
}
