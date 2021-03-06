using System;

using HiUwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace HiUwp.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
