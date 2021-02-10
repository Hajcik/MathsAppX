using MathsAppX.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MathsAppX.Views
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