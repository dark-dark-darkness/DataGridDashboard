using ReactiveUI;

namespace DataGridDashboard.ViewModels;
public class BaseViewModel : ReactiveObject, IActivatableViewModel
{
    public ViewModelActivator Activator { get; } = new();
}
