namespace ExpWithElementsOfMAUI.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
		Button button = new Button
		{
			WidthRequest = 100,
			HeightRequest = 50,
			Text = "Click"
		};
		Content=new Grid { Children = { button } };
	}
}