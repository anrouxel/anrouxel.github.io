using anrouxel.ViewModels;
using ReactiveUI.Blazor;
using ReactiveUI;

namespace anrouxel.Views.Home.Sections
{
    public partial class Home: ReactiveInjectableComponentBase<HomeViewModel>
    {
        public Home()
        {
            this.WhenActivated(disposables => {});
        }

        protected override void OnInitialized()
        {
            ViewModel!.GetProfile.Execute().Subscribe();
        }
    }
}