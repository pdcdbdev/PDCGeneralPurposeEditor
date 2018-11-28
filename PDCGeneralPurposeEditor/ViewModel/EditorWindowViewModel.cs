using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PDCGeneralPurposeEditor.Annotations;
using Reactive.Bindings;

namespace PDCGeneralPurposeEditor.ViewModel
{
    public class EditorWindowViewModel:INotifyPropertyChanged
    {
        public ReactiveCommand menuItem_SaveTemporaryData_Click { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
