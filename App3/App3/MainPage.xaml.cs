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
            lblResult.Text = entryNumber.Text;
            var song = Int32.Parse(entryNumber.Text).ToString("000");
            Navigation.PushAsync(new WebViewPage($"Z{song}.pdf"));
        }
    }
}
