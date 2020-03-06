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
    public partial class Analytics : ContentPage
    {
        public Analytics()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                StackLayout mainstack = new StackLayout() { HorizontalOptions = LayoutOptions.FillAndExpand };

                for (int i = 0; i < 10; i++)
                {
                    Frame fr = new Frame() { Padding = 0, Margin = 2, HasShadow = false };

                    StackLayout stackLayout = new StackLayout() { Orientation = StackOrientation.Horizontal };

                    StackLayout _stackLayout = new StackLayout() { WidthRequest = 10 };
                    StackLayout stack = new StackLayout() { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(5, 15, 20, 15) };

                    StackLayout Stack1 = new StackLayout() { VerticalOptions = LayoutOptions.CenterAndExpand };
                    StackLayout Stack2 = new StackLayout() { VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.EndAndExpand };

                    Label dateRec = new Label() { Text = "Feb 2, 2020 09:25 AM", HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16, Margin = new Thickness(0, -5, 0, -5) };
                    Label Particulars = new Label() { Text = "Table Number 1", HorizontalOptions = LayoutOptions.FillAndExpand, TextColor = Color.Black, FontSize = 18 };

                    Image img = new Image() { Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.EndAndExpand, Source = "decrementBlack.png", Margin = -5 };
                    Label amt = new Label() { Text = "Rs. 345", HorizontalOptions = LayoutOptions.EndAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand, TextColor = Color.Black, FontSize = 18 };

                    if (i % 2 == 0)
                    {
                        //upBlack
                        img.Source = "upBlack.png";
                        fr.BorderColor = Color.FromHex("#028402");
                        _stackLayout.BackgroundColor = Color.FromHex("#028402");
                    }
                    else
                    {
                        //img.Source = "decrementBlack.png";
                        fr.BorderColor = Color.FromHex("#AC1D1D");
                        _stackLayout.BackgroundColor = Color.FromHex("#AC1D1D");
                    }

                    Stack1.Children.Add(Particulars);
                    Stack1.Children.Add(dateRec);

                    Stack2.Children.Add(img);
                    Stack2.Children.Add(amt);

                    stack.Children.Add(Stack1);
                    stack.Children.Add(Stack2);

                    stackLayout.Children.Add(_stackLayout);
                    stackLayout.Children.Add(stack);

                    fr.Content = stackLayout;
                    mainstack.Children.Add(fr);
                }
                body.Children.Clear();
                body.Children.Add(mainstack);
               
            });
        }
        
    }
}