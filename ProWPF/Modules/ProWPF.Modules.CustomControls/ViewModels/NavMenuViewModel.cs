using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Regions;
using ProWPF.Core.Mvvm;

namespace ProWPF.Modules.CustomControls.ViewModels
{
  public class NavMenuViewModel : RegionViewModelBase
  {
    public IList<KeyValuePair<string, string>> Menus { get; } =
    [
      new KeyValuePair<string, string>("ToolTip", "CustomToolTip")
    ];

    public DelegateCommand<string> NavigateCommand { get; }

    public NavMenuViewModel(IRegionManager regionManager) : base(regionManager)
    {
      NavigateCommand = new DelegateCommand<string>(NavigateToView, CanNavigateToView);
    }

    private void NavigateToView(string viewName)
    {
      RegionManager.RequestNavigate(RegionNames.LayoutMainRegion, viewName);
    }

    private bool CanNavigateToView(string viewName)
    {
      //var view = RegionManager.Regions[RegionNames.LayoutMainRegion].ActiveViews
      //  .SingleOrDefault(v => v.GetType().Name == viewName);

      //return view == null;
      return true;
    }
  }
}
