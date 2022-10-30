using GymProject.VistaModelo;
using GymProject.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GymProject.VistaModelo
{
    public class VMCrearCuenta : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMCrearCuenta(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task IraRegistro()
        {
            await Navigation.PushAsync(new VRegistro());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand IrCrearCuenttaCommand => new Command(async () => await IraRegistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}