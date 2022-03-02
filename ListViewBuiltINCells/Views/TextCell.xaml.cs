using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewBuiltINCells.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextCell : ContentPage
    {
        public TextCell()
        {
            InitializeComponent();
            lstView.ItemsSource = DataSource.Students;
        }
    }
}