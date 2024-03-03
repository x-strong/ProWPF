using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ProWPF.Core.Attributes;

namespace ProWPF.Modules.CustomControls.Views
{
  /// <summary>
  /// Interaction logic for NavMenu.xaml
  /// </summary>
  [Navigatable]
  public partial class NavMenu : UserControl
  {
    public NavMenu()
    {
      InitializeComponent();
    }
  }
}
