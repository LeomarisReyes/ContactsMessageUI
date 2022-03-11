using System;
using System.Collections.Generic;
using ContactsMessageUI.ViewModels;
using Xamarin.Forms;

namespace ContactsMessageUI.Views
{
    public partial class MessagePage : ContentPage
    {
        public MessagePage()
        {
            InitializeComponent();
            BindingContext = new ContactsViewModel();

        }
    }
}
