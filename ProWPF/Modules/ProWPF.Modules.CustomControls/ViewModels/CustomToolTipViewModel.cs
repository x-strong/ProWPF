using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls.Primitives;
using Prism.Regions;
using ProWPF.Core.Mvvm;
using ProWPF.Services.Interfaces;

namespace ProWPF.Modules.CustomControls.ViewModels
{
  public class CustomToolTipViewModel : RegionViewModelBase
  {
    private string _message;

    public string Message
    {
      get { return _message; }
      set { SetProperty(ref _message, value); }
    }

    public IEnumerable<PlacementMode> Placements { get; } = Enum.GetValues(typeof(PlacementMode)).Cast<PlacementMode>();

    public CustomToolTipViewModel(IRegionManager regionManager, IMessageService messageService) :
      base(regionManager)
    {
      Message = messageService.GetMessage();
    }

    public override void OnNavigatedTo(NavigationContext navigationContext)
    {
      //do something
    }
  }
}
