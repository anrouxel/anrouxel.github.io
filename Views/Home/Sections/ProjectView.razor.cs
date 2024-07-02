using anrouxel.ViewModels;
using ReactiveUI.Blazor;
using ReactiveUI;

namespace anrouxel.Views.Home.Sections
{
    public partial class ProjectView: ReactiveInjectableComponentBase<ProjectViewModel>
    {
        public ProjectView()
        {
            this.WhenActivated(disposables => {});
        }

        protected override void OnInitialized()
        {
            ViewModel!.GetRepositories.Execute().Subscribe();
        }
    }
}