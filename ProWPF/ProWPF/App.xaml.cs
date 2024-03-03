using System.Windows;

using Prism.Ioc;
using Prism.Modularity;
using ProWPF.Modules.CustomControls;
using ProWPF.Services;
using ProWPF.Services.Interfaces;
using ProWPF.Views;

namespace ProWPF
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    protected override Window CreateShell()
    {
      return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterSingleton<IMessageService, MessageService>();
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
      moduleCatalog.AddModule<CustomControlsModule>();
    }
  }
}
