using System.Reactive.Linq;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using System;

using ReactiveUI;
using System.Reactive.Disposables;
using DataGridDashboard.Views;

namespace DataGridDashboard;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var mainView = new MainView();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var window = new ReactiveWindow<object> { Content = mainView};
            window.WhenActivated(_ =>
            {
                Observable
                    .FromEventPattern<PointerPressedEventArgs>(window,nameof(window.PointerPressed))
                    .Where(x => x.EventArgs.Pointer.IsPrimary)
                    .Subscribe(e => window.BeginMoveDrag(e.EventArgs))
                    .DisposeWith(_);
            });
            desktop.MainWindow = window;
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime single)
        {
            single.MainView = mainView;
        }

        base.OnFrameworkInitializationCompleted();
    }
}