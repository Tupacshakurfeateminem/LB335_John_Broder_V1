using LB335_John_Broder_V1.ViewModel;

namespace LB335_John_Broder_V1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

       
    }
}