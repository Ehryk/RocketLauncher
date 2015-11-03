using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RocketLauncher.ViewModels
{
    public class CountdownViewModel : BaseViewModel
    {
        #region Properties

        int? countdown = null;
        bool cancelled = false;
        bool launched = false;

        #endregion

        #region Constructors

        public CountdownViewModel()
        {
            countdown = 0;
            StartTimer();
        }

        public CountdownViewModel(int? countdown)
        {
            this.countdown = countdown;
            StartTimer();
        }

        #endregion

        #region Public Properties

        public int? Countdown
        {
            get { return countdown; }
            set
            {
                if (countdown != value)
                {
                    countdown = value;
                    Notify("Countdown");
                    Notify("Status");
                }
            }
        }

        public bool Cancelled
        {
            get { return cancelled; }
            set
            {
                if (cancelled != value)
                {
                    cancelled = value;
                    Notify("Cancelled");
                    Notify("Status");
                }
            }
        }

        public bool Launched
        {
            get { return launched; }
            set
            {
                if (launched != value)
                {
                    launched = value;
                    Notify("Launched");
                    Notify("Status");
                    Notify("AbortText");
                }
            }
        }

        public string Status
        {
            get
            {
                if (Cancelled)
                    return "Launch Cancelled.";
                else if (Launched)
                    return "Launched Successfully.";
                else if (Countdown == null || Countdown.Value <= 0)
                    return "Liftoff!!!";
                else
                    return string.Format("Launching in T-{0} seconds...", Countdown);
            }
        }

        public string AbortText
        {
            get
            {
                return Launched ? "RETURN" : "ABORT";
            }
        }

        #endregion

        #region Methods

        protected bool StartTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (Countdown == null)
                    return false;
                else if (Countdown <= -3)
                    //Todo: Check for actual launch
                    Launched = true;
                else
                    Countdown = Countdown - 1;
                return true;
            });

            return true;
        }

        #endregion
    }
}
