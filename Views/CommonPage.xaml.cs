using ExpWithElementsOfMAUI.ViewModels;

namespace ExpWithElementsOfMAUI.Views;

public partial class CommonPage : ContentPage
{
	public CommonPage(CommonPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}