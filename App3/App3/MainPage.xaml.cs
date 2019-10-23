using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnMappe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MappePage());
        }

        private void btnZionsharfe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ZionsharfePage());
        }
    }
}
