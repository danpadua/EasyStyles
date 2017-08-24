using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace EasyStylesApp.Utils
{
    public class RangeEnabledObservableCollections<T> : ObservableCollection<T>
    {
        public void InsertRange(IEnumerable<T> items)
        {
            CheckReentrancy();
            foreach (var item in items) Items.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}