using GymProject.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymProject.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VCrearCuenta : ContentPage
    {
        public VCrearCuenta()
        {
            InitializeComponent();
            BindingContext = new VMCrearCuenta(Navigation);
        }
    }
}