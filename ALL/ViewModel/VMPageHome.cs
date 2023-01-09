﻿using ALL.View;
using MvvmGuia.VistaModelo;
using System.Windows.Input;
using Xamarin.Forms;

namespace ALL.ViewModel
{
    public class VMPageHome : BaseViewModel
    {
        public VMPageHome(INavigation navigation)
        {
            Navigation = navigation;
        }
        public ICommand btnGoAlertCommand => new Command(async () => await Navigation.PushAsync(new PageAlert()));
        public ICommand btnGoEntryCommand => new Command(async () => await Navigation.PushAsync(new EntryPage()));
        public ICommand btnGoCalculatorCommand => new Command(async () => await Navigation.PushAsync(new Calculadora()));
        public ICommand btnGoPickerCommand => new Command(async () => await Navigation.PushAsync(new PagePicker()));
        public ICommand btnGoDatePickerCommand => new Command(async () => await Navigation.PushAsync(new PageDatePicker()));

    }
}
