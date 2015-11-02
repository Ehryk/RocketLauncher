using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace RocketLauncher.ViewModels
{
    public class ConfigurationViewModel : INotifyPropertyChanged
    {
        #region Properties

        #endregion

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors

        public ConfigurationViewModel()
        {
        }

        #endregion

        #region Public Properties
        


        #endregion

        #region Methods

        protected void Notify(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
