using MathApp.Data;
using MathApp.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233
using Windows.UI.Popups;

namespace MathApp
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class ItemsPage : MathApp.Common.LayoutAwarePage
    {
        public ItemsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Invoked when an item is clicked.
        /// </summary>
        /// <param name="sender">The GridView (or ListView when the application is snapped)
        /// displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void LineaRecta_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RectaPage));
        }

        private void Circunferencia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Parábola_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Elipse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hiperbola_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void About_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog message = new MessageDialog("Message", "Title");
            await message.ShowAsync();
        }
    }
}
