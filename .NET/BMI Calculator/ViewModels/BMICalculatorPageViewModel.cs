using BMI_Calculator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.ViewModels
{
    [QueryProperty("Name", "Text")]
    public partial class BMICalculatorPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double _height = 1;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BMIScore))]
        [NotifyPropertyChangedFor(nameof(BMIResult))]
        public double _weight = 1;

        public double BMIScore
            => Math.Round(Weight/Math.Pow(Height / 100, 2), 2);

        public string BMIResult
        {
            get
            {
                if (BMIScore < 18.5)
                    return "Underweight";
                else if (BMIScore < 25)
                    return "Healthy";
                else if (BMIScore < 30)
                    return "Overweight";
                else
                    return "Obese";
            }
        }

        [RelayCommand]
        private async void SaveData()
        {
            DateTime dateTime = DateTime.UtcNow;
            String TimeStamp = dateTime.ToString();

            await App.BMIRepo.AddNewBMIData(Name, Height, Weight, BMIScore, BMIResult, TimeStamp);
            await Shell.Current.GoToAsync(nameof(BMIListPage));
        }
    }
}
