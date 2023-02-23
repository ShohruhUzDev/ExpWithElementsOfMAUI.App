namespace ExpWithElementsOfMAUI.Views;

public partial class SecondPage : ContentPage
{
    public int value = 10;
	public SecondPage()
	{
		InitializeComponent();
    }

    private  async void Hello_Pressed(object sender, EventArgs e)
    {
        await scroll.ScrollToAsync(0, 2, true);
    }

    


    

    private void swithcer_Toggled(object sender, ToggledEventArgs e)
    {
        value_txt.Text=$"{e.Value}";
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        stevalue_txt.Text =$"{e.NewValue}";
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton radioButton=(RadioButton)sender;    
        radio_label.Text=radioButton.Content.ToString();

    }
}