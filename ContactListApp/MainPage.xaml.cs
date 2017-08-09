using ContactListApp.ViewModels;
using Xamarin.Forms;

namespace ContactListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ContactListViewModels();
        }
    }
}
