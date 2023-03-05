using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoreImage;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace MyTask.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<String>();
    }

    [ObservableProperty]
    ObservableCollection<String> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text))
            return;

        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if(Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}
