
using System;
using System.ComponentModel;
using Xamarin.Forms;
namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is Picker picker)
            {
                string selectedValue = picker.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "4":
                        DiceImage.Source = "d4.jpg";
                        break;
                    case "6":
                        DiceImage.Source = "d6.jpg";
                        break;
                    case "10":
                        DiceImage.Source = "d10.jpg";
                        break;
                    case "20":
                        DiceImage.Source = "d20.jpg";
                        break;
                    case "100":
                        DiceImage.Source = "d100.jpg";
                        break;
                }
            }
        }

    private void SortearNumeroAleatorio(object sender, EventArgs e)
    {
        var maxValue = SeletorDeLadosDoDado.SelectedItem;
        var numeroSorteado = new Random().Next(1, (int)maxValue + 1);

        NumeroSorteado.Text = numeroSorteado.ToString();
    }

}
}
