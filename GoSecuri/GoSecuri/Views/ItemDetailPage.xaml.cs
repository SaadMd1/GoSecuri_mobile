using GoSecuri.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GoSecuri.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}