using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace RocketLauncher.ViewModels
{
    public class CountdownViewModel : BaseViewModel
    {
        #region Properties

        int? countdown = null;
        bool cancelled = false;

        #endregion

        #region Constructors

        public CountdownViewModel()
        {
        }

        public CountdownViewModel(int? countdown)
        {
            this.countdown = countdown;
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

        public string Status
        {
            get
            {
                if (Cancelled)
                    return "Launch Cancelled.";
                else if (Countdown == null)
                    return "Liftoff!!!";
                else
                    return string.Format("Launching in T-{0} seconds...", Countdown);
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
