using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MappePage : ContentPage
    {
        public MappePage()
        {
            InitializeComponent();
        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = entryNumber.Text;
            var song = Int32.Parse(entryNumber.Text).ToString("000");
            Navigation.PushAsync(new WebViewPage($"Mappe/M{song}.pdf"));
        }
    }
}