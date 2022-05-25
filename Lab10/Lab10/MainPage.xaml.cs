using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void GoToViewToViewDemo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewToViewDemo());
        }
        private void GoToBindingModeDemo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingModeDemo());
        }
        private void GoToListViewDemo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewDemo());
        }
        private void GoToPickerDemo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PickerDemo());
        }
    }
}
