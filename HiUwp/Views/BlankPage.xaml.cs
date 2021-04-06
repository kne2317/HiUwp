using System;

using HiUwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace HiUwp.Views
{
    public sealed partial class BlankPage : Page
    {
        private BlankViewModel ViewModel => DataContext as BlankViewModel;

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
