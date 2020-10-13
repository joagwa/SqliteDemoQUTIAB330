using System.ComponentModel;
using Xamarin.Forms;
using SqliteDemo.ViewModels;

namespace SqliteDemo.Views
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