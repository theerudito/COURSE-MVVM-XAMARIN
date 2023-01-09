using MvvmGuia.VistaModelo;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMCalculator : BaseViewModel
    {
        #region VARIABLE
        string _num1;
        string _num2;
        string _resultado;
        #endregion

        #region CONTRUCTOR
        public VMCalculator(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETO
        public string Number1
        {
            get { return _num1; }
            set { SetValue(ref _num1, value); }
        }

        public string Number2
        {
            get { return _num2; }
            set { SetValue(ref _num2, value); }
        }

        public string Result
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        #endregion

        #region METODO
        public void SUMAR()
        {
            Result = (Convert.ToDouble(Number1) + Convert.ToDouble(Number2)).ToString();

            Number1 = "";
            Number2 = "";
        }
        #endregion

        #region COMANDO
        public ICommand btnSumaCommand => new Command(SUMAR);
        #endregion
    }
}
