using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewIssues
{
  public class MainPageViewModel : INotifyPropertyChanged
  {
    private int _entriesToGenerate;
    public event PropertyChangedEventHandler PropertyChanged;

    public int EntriesToGenerate
    {
      get => _entriesToGenerate;
      set
      {
        _entriesToGenerate = value;
        OnPropertyChanged();
      }
    }

    public ICommand ShowSelectionDialog => new Command(o =>
    {
      var itemCount = (int) o;
      var items = Enumerable.Range(1, itemCount)
                            .Select(i => $"Item {i}");

      App.Current.MainPage.Navigation.PushAsync(new SelectionDialog(items));
    });
    

    protected virtual void OnPropertyChanged
    (
      [CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
