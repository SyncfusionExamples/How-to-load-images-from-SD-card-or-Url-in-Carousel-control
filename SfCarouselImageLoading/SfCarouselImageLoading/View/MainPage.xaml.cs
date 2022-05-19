using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfCarouselImageLoading
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void URLButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new URLCarouselPage());
        }

        private void SDButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SDCarouselPage());
        }
    }
}
