namespace TemplateMauiApp;

public partial class MainPage : ContentPage
{
	public static readonly BindableProperty RacesProperty = BindableProperty.Create("Races", typeof(string[]), typeof(MainPage), new string[] { "option1", "option2" });

    public string[] Races
    {
        get => (string[])GetValue(RacesProperty);
        set => SetValue(RacesProperty, value);
    }

    public MainPage()
	{
		InitializeComponent();
        this.racePicker.BindingContext = this;
        this.racePicker.SetBinding(RacesProperty, new Binding("Races"));
		this.saveButton.Clicked += (obj, args) => 
		{
			this.DisplayAlert("Alert", "message", "cancel");

        };
	}
}

