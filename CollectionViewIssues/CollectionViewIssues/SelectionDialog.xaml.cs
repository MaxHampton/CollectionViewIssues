using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace CollectionViewIssues
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SelectionDialog : PopupPage
  {
    public SelectionDialog(IEnumerable<string> items)
    {
      InitializeComponent();

      Task.Run(async () =>
      {
        await Task.Delay(3000);
        MainThread.BeginInvokeOnMainThread(() =>
        {
          ItemsCollection.ItemsSource = items;
        });
      });
    }
  }
}