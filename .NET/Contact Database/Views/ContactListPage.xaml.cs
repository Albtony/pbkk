using Contact_Database.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Contact_Database.Views;

public partial class ContactListPage : ContentPage
{
    public ContactListPage()
    {
        InitializeComponent();
    }
    void OnGetContactClicked(object sender, EventArgs args)
    {
        //List<Models.Contact> contactList = await App.contactRepo.GetContactList();
        //_contactList.ItemsSource = contactList;
    }
}