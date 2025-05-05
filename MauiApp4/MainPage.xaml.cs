namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            ((MainViewModel)this.BindingContext).AppareCommand.Execute(null);
            base.OnAppearing();
        }
    }

}
