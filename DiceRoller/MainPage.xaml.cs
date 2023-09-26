namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SeletorDeLadosDoDado.SelectedIndexChanged += Picker_SelectedIndexChanged;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is Picker picker)
            {
                string selectedValue = picker.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "4":
                        UpdateDiceImage("d4.jpg");
                        break;
                    case "6":
                        UpdateDiceImage("d6.jpg");
                        break;
                    case "10":
                        UpdateDiceImage("d10.jpg");
                        break;
                    case "20":
                        UpdateDiceImage("d20.jpg");
                        break;
                    case "100":
                        UpdateDiceImage("d100.jpg");
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

        private void UpdateDiceImage(string imageName)
        {
            DiceImage.Source = imageName;
        }
    }
}