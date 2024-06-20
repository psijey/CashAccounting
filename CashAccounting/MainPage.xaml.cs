

using System.Text;

namespace CashAccounting
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
            {
                CounterBtn.Text = $"Clicked {count} time";
                countText.Text = Convert.ToString(count);
            }
            else
            {
                CounterBtn.Text = $"Clicked {count} times";
                countText.Text = Convert.ToString(count);
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private async void OnPageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NewPage1");
            
        }
        
    }
}