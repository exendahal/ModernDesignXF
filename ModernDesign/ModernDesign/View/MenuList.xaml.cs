using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModernDesign.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuList : ContentPage
    {
        public MenuList()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalesGraph());
        }
    }
}