using System;
using System.Reflection;
using Xamarin.Forms;

namespace TestApp
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            ResourceImage.Source = ImageSource.FromResource("TestApp.test.png");
            FileImage.Source = ImageSource.FromFile("test.png");
        }
    }
}
