using ProjetoOnboardingPage.ViewModels;

namespace ProjetoOnboardingPage.Views;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage(OnboardingViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}