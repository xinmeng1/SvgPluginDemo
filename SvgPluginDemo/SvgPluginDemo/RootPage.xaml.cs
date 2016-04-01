using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvgPluginDemo.ViewModels;
using Xamarin.Forms;

namespace SvgPluginDemo
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
            BindingContext = new ViaXamlViewModel();
        }
    }
}
