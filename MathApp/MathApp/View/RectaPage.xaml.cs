using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MathApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RectaPage : Page
    {
        public RectaPage()
        {
            this.InitializeComponent();
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Intro_Click(object sender, RoutedEventArgs e)
        {
            var result = App.Current.Resources["PuntoPendiente"] as DataTemplate;
            BodyApp.ContentTemplate = result;
            BodyApp.Header = "Punto Pendiente";
        }

        private void Saludo_Click(object sender, RoutedEventArgs e)
        {
            BodyApp.ContentTemplate = App.Current.Resources["Introduccion"] as DataTemplate;
            BodyApp.Header = "Hola mundo";
        }

    }
}
