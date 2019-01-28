using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //for safe area in iOS
            //https://blog.xamarin.com/making-ios-11-even-easier-xamarin-forms/
        }
    }
}
