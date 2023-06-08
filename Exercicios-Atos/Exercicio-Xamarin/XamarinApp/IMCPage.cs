using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinApp;

namespace IMCCalculator
{
    public partial class IMCPage : ContentPage
    {
        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            // Código para calcular o IMC
            double peso = double.Parse(pesoInput.Text);
            double altura = double.Parse(alturaInput.Text) / 100;
            double imc = peso / (altura * altura);

            lblResultado.Text = $"IMC = {imc.ToString("F2")}";
        }

        private async void GoToEmailGeneratorPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}