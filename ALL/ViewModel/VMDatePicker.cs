using MvvmGuia.VistaModelo;
using System;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMDatePicker : BaseViewModel
    {

        #region VARIABLE
        DateTime _Fecha;
        string _FechaString;
        #endregion

        #region CONTRUCTOR
        public VMDatePicker(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion

        #region OBJETO
        public DateTime Fecha
        {
            get { return _Fecha; }
            set
            {
                _Fecha = value;
                ResultadoFecha = Fecha.ToString("dd/MM/yyyy");
            }
        }

        public string ResultadoFecha
        {
            get { return _FechaString; }
            set
            {
                SetValue(ref _FechaString, value);
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
