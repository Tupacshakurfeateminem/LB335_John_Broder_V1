using LB335_John_Broder_V1.ViewModel;

namespace LB335_John_Broder_V1;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}