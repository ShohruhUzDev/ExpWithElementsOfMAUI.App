namespace ExpWithElementsOfMAUI.Views;

public partial class SecondPage : ContentPage
{
    public int value = 10;

	public SecondPage(SecondPageViewModel secondPageViewModel)
	{
		InitializeComponent();
      

        BindingContext =secondPageViewModel;

    }

    private  async void Hello_Pressed(object sender, EventArgs e)
    {
        await scroll.ScrollToAsync(0, 2, true);
    }

    


    

    //private void swithcer_Toggled(object sender, ToggledEventArgs e)
    //{
    //    value_txt.Text=$"{e.Value}";
    //}

    //private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    //{
    //    stevalue_txt.Text =$"{e.NewValue}";
    //}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton radioButton=(RadioButton)sender;    
        //radio_label.Text=radioButton.Content.ToString();

    }
    ////protected override async void OnAppearing()
    ////{
    ////    while(progress.Progress<0.9)
    ////    {
            

    ////            progress.Progress += 0.1;
    ////            proglabel.Text = $"Holat:{Math.Round(progress.Progress, 1) * 100}%";
    ////            await Task.Delay(1000);

    ////        if (progress.Progress >0.9)
    ////            progress.Progress = 0;
    ////    }
    ////    proglabel.Text = "Finished";
    ////    base.OnAppearing();
    ////}
}