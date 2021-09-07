using System;
using Xamarin.Forms;
using xamarin_collection_view.ViewModel;

namespace xamarin_collection_view
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new CollectionViewModel();
        }
    }
}
