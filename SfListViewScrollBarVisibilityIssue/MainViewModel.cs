using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SfListViewScrollBarVisibilityIssue
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public MainViewModel()
        {
            Items = new ObservableCollection<Item>();

            for (var i = 0; i < 100; i++)
            {
                Items.Add(new Item
                {
                    Name = $"Item {i}"
                });
            }
        }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                RaiseOnPropertyChanged();
            }
        }
    }
}