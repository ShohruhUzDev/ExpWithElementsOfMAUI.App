namespace ExpWithElementsOfMAUI.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
    }

    private  async void Hello_Pressed(object sender, EventArgs e)
    {
        await scroll.ScrollToAsync(0, 2, true);
    }

    


    private void salom_Completed_1(object sender, EventArgs e)
    {
        DisplayAlert("hello", "Tugatilganda", "ok");
    }
}