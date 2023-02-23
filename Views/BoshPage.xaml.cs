using ExpWithElementsOfMAUI.ViewModels;

namespace ExpWithElementsOfMAUI.Views;

public partial class BoshPage : ContentPage
{
	public BoshPage( BoshPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
	}
}