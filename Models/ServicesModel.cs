﻿using firstMobileApp.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMobileApp.Models
{
    internal class ServicesModel : INotifyPropertyChanged
    {
        API api;
        private ObservableCollection<Services> _servicesList;



        public ServicesModel()
        {
            api = new API();
            ServicesList = new ObservableCollection<Services>();
            LoadData();
        }

        private async void LoadData()
        {
            var result = await api.GetPostData("/services");
            List<Services> servicesList = JsonConvert.DeserializeObject<List<Services>>(result);

            foreach (var user in servicesList)
            {
                ServicesList.Add(user);
            }
        }

        public ObservableCollection<Services> ServicesList
        {
            get { return _servicesList; }
            set
            {
                if (_servicesList != value)
                {
                    _servicesList = value;
                    OnPropertyChanged(nameof(ServicesList));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
