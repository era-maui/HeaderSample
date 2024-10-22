namespace HeaderSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		MyList.ItemsSource = new List<string> { "Alpha", "Beta", "Gamma" };

	}


}

