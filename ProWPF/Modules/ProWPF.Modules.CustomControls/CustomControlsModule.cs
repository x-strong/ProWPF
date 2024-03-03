using System.Linq;
using System.Reflection;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ProWPF.Core.Attributes;
using ProWPF.Modules.CustomControls.Views;
using GlobalRegionNames = ProWPF.Core.RegionNames;

namespace ProWPF.Modules.CustomControls
{
  public class CustomControlsModule : IModule
  {
    private readonly IRegionManager _regionManager;

    public CustomControlsModule(IRegionManager regionManager)
    {
      _regionManager = regionManager;
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
      _regionManager.RequestNavigate(GlobalRegionNames.ContentRegion, nameof(Layout));
      _regionManager.RequestNavigate(RegionNames.LayoutLeftRegion, nameof(NavMenu));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
      var viewTypes = Assembly.GetExecutingAssembly().GetTypes()
        .ToList()
        .FindAll(t => t.CustomAttributes.Any(c => c.AttributeType == typeof(NavigatableAttribute)));

      viewTypes.ForEach(t => containerRegistry.RegisterForNavigation(t, t.Name));

      //containerRegistry.RegisterForNavigation<Layout>();
    }
  }
}
