using BMI_Calculator.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BMI_Calculator.Views;

public partial class BMIListPage : ContentPage
{
	public BMIListPage()
	{
		InitializeComponent();
    }
    async void OnGetContactClicked(object sender, EventArgs args)
    {
        //await Shell.Current.GoToAsync(nameof(BMICalculatorPage));
        List<BMIData> BMIList = await App.BMIRepo.GetBMIList();
        _contactList.ItemsSource = BMIList;
    }
}