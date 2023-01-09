using MvvmGuia.VistaModelo;
using System.Windows.Input;
using System;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPagePicker : BaseViewModel
    {
        #region VARIABLE
        string _Cargo;
        #endregion

        #region CONTRUCTOR
        public VMPagePicker(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETO
        public string Cargo
        {
            get { return _Cargo; }
            set { SetValue(ref _Cargo, value); }
        }
        public string SelecionarCargo
        {
            get { return _Cargo; }
            set
            {
                SetProperty(ref _Cargo, value);
                Cargo = _Cargo;
            }
        }

        #endregion

        #region METODO
        public void GetCargo()
        {

        }
        #endregion

        #region COMANDO
        //public ICommand btnSumaCommand => new Command(GetCargo);
        #endregion
    }
}
