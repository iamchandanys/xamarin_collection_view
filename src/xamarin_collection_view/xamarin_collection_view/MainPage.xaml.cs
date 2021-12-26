using System;
using System.Collections.Generic;
using System.Linq;
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

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var current = (e.CurrentSelection.FirstOrDefault() as MyModel);
        }
    }
}
