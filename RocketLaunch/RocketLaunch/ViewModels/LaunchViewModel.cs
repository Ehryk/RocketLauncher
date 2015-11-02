using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace RocketLaunch.ViewModels
{
    public class LaunchViewModel : INotifyPropertyChanged
    {
        #region Properties

        bool connected = true;
        bool armed = false;
        string deviceName = null;
        int delay = 0;

        #endregion

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors

        public LaunchViewModel(bool connected = false, bool armed = false, string deviceName = null, int delay = 0)
        {
            this.connected = connected;
            this.armed = armed;
            this.deviceName = deviceName;
            this.delay = delay;
        }

        #endregion

        #region Public Properties

        public bool Connected
        {
            get { return connected; }
            set
            {
                if (connected != value)
                {
                    connected = value;
                    Notify("Connected");
                }
            }
        }

        public bool Armed
        {
            get { return armed; }
            set
            {
                if (armed != value)
                {
                    armed = value;
                    Notify("Armed");
                }
            }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set
            {
                if (deviceName != value)
                {
                    deviceName = value;
                    Notify("DeviceName");
                }
            }
        }

        public int Delay
        {
            get { return delay; }
            set
            {
                if (delay != value)
                {
                    delay = value;
                    Notify("Delay");
                }
            }
        }

        public string Status
        {
            get { return string.Format("{0}, {1}", Connected ? "Connected to '" + deviceName + "'" : "Not Connected", Armed ? "Armed" : "Unarmed"); }
        }

        #endregion

        #region Methods

        protected void Notify(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Connected"));
        }

        #endregion
    }
}
