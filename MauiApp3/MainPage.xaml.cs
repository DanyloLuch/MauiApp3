namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberEntry.Text, out int number))
            {
                DisplayAlert("Результат", $"Ви ввели число {number}", "OK");
            }
            else
            {
                DisplayAlert("Помилка", "Будь ласка, введіть ціле число.", "OK");
            }
        }
    }

}
