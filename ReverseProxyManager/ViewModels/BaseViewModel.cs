using System;
using System.Runtime.CompilerServices;

namespace ReverseProxyManager.ViewModels
{
    abstract public class BaseViewModel : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {
        string title = "Untitled ViewModel";
        public string Title { get => title; set => SetField(ref title, value); }

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;


        protected void SetField<T>(ref T field, T value, [CallerMemberName] string property = null) {
            NotePropertyChanging(property);
            field = value;
            NotePropertyChanged(property);
        }


        protected void NotePropertyChanging([CallerMemberName] string property = null)
        {
            PropertyChanging?.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(property));
        }

        protected void NotePropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(property));
        }
    }
}

