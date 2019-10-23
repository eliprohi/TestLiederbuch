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
    public partial class WebViewPage : ContentPage
    {
        private string pdf;
        public WebViewPage()
        {
            InitializeComponent();            
        }

        public WebViewPage(string pdf) : this()
        {
            this.pdf = pdf;
            this.Resources.Add("PDF", pdf);
        }


    }
}