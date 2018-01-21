using System;
using Windows.UI.Xaml.Controls;
using ProIndian.Model;
using ProIndian.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProIndian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MinistriesPage : Page
    {

        public MinistriesPage()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();

        }
        public MainViewModel ViewModel { get; private set; }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string stringURI = ((Ministry)MinistryListView.SelectedValue).MinistryWebsite;
            var siteURI = new Uri(stringURI);
            WebviewMinistry.Navigate(siteURI);
            //   var success = await Windows.System.Launcher.LaunchUriAsync(siteURI);
            //if (success) { }
            //else {   }
        }

    }
}
