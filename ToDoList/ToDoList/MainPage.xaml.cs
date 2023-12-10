using System;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ToDoList
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowItems();
        }
        public void ShowItems()
        {
            itemsCollection.ItemsSource = App.Db.GetItems();
        }
        private async void CraetePageOpen(object sender, EventArgs e)
        {
            CreatePage createPage = new CreatePage();
            await Navigation.PushAsync(createPage);
            ShowItems();

        }
        private async void OnCheckBoxChecked(object sender, CheckedChangedEventArgs e)
        {

            CheckBox checkBox = (CheckBox)sender;

            StackLayout parentStackLayout = (StackLayout)checkBox.Parent;
            Label itemIdLabel = parentStackLayout.FindByName<Label>("ItemIdLabel");

            if (itemIdLabel != null && int.TryParse(itemIdLabel.Text, out int itemId))
            {
                await Task.Delay(500);
                App.Db.DeleteItemById(itemId);
                ShowItems();
            }
        }
    }
}
