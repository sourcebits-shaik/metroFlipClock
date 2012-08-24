using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace metroflip
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private int _seconds = DateTime.Now.Second;
        private int _minutes = DateTime.Now.Minute;
        private int _hours = DateTime.Now.Hour;
        private void Timer_Tick1(object sender, object e)
        {

            if (_minutes == 59)
            {
                Minutes.Value(_minutes.ToString("00"), 0.ToString("00"));
                _minutes = 0;
                if (_hours == 23)
                {
                    Hours.Value(_hours.ToString("00"), 0.ToString("00"));
                    _hours = 0;
                }
                else
                {
                    Hours.Value(_hours.ToString("00"), (_hours + 1).ToString("00"));
                    _hours += 1;
                }
            }
            else
            {
                Minutes.Value(_minutes.ToString("00"), (_minutes + 1).ToString("00"));
                _minutes += 1;
            }


        }


        public MainPage()
        {
            this.InitializeComponent();

            Minutes.TextPrev = _minutes.ToString("00");
            Hours.TextPrev = _hours.ToString("00");
            _timer.Tick += new System.EventHandler<System.Object>(Timer_Tick1);
            _timer.Interval = TimeSpan.FromMinutes(1);
            _timer.Start();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
