﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using firstMobileApp.Class;

namespace firstMobileApp.Models
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Event> _eventList;

        public ObservableCollection<Event> EventList
        {
            get { return _eventList; }
            set
            {
                if (_eventList != value)
                {
                    _eventList = value;
                    OnPropertyChanged(nameof(EventList));
                }
            }
        }

        public ViewModel()
        {
            EventList = new ObservableCollection<Event>();

            // Ajoutez plusieurs événements simulés
            for (int i = 1; i <= 5; i++)
            {
                EventList.Add(new Event
                {
                    Title = $"Événement {i}",
                    Description = $"Description de l'événement {i}",
                    ProfilePhoto = $"logo_site.png",
                    EventPhoto = $"des_sports.jpg",
                    Date = DateTime.Now.AddDays(i)
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}