namespace TemplateMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
		this.openDialogButton.Clicked += (obj, args) => 
		{
			this.DisplayAlert("Alert", "message", "cancel");
        };
	}
}

