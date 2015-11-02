using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace RocketLauncher.ViewModels
{
    public class LaunchViewModel : INotifyPropertyChanged
    {
        #region Properties

        bool connected = false;
        bool armed = false;
        string deviceName = null;
        int delay = 0;

        #endregion

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructors

        public LaunchViewModel()
        {
        }

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
                    Notify("Status");
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
                    Notify("Status");
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
                    Notify("Status");
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
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
