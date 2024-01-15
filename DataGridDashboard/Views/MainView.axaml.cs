using Avalonia.Controls;
using Avalonia.ReactiveUI;

using DataGridDashboard.ViewModels;

namespace DataGridDashboard.Views;
public partial class MainView  : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        ViewModel = new MainViewModel();
        InitializeComponent();
    }
}
