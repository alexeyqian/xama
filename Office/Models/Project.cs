using System;
using System.ComponentModel;

namespace Office.Models
{
    public class Project : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private string _description;
        private string _imageUrl;
        private bool _isStarted;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }

        public bool IsStarted
        {
            get => _isStarted;
            set
            {
                _isStarted = value;
                RaisePropertyChanged(nameof(IsStarted));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
