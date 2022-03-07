using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace ScreenRecorder_2
{

    public partial class CountdownTimer : System.Windows.Controls.UserControl
    {
        private DispatcherTimer _timer;
        public TimeSpan _time = new TimeSpan(0, 0, 2);
        bool isRuning = false;

        public TextBox textbox
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
            }
        }

        public CountdownTimer()
        {
            InitializeComponent();
            //textbox.TextChanged += Textbox_TextChanged;
            h.Text = m.Text = s.Text = "0";
            int hours = Convert.ToInt32(h.Text);
            int seconds = Convert.ToInt32(s.Text);
            int minutes = Convert.ToInt32(m.Text);
            _time = new TimeSpan(hours, minutes, seconds);

            s.TextChanged += S_TextChanged;
        }

        //private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (_time == TimeSpan.Zero && h.Text == "0" && m.Text == "0" && s.Text == "0")
        //    {
        //        MessageBox.Show("END");
        //    }
        //}

        private void S_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isRuning)
            {
                if (buttom.Fill == Brushes.White)
                {
                    buttom.Fill = Brushes.Red;
                }
                else
                {
                    buttom.Fill = Brushes.White;
                }
            }

        }

        private void bt_down(object sender, MouseButtonEventArgs e)
        {
            if (!isRuning)
            {
                isRuning = true;
                h.IsReadOnly = m.IsReadOnly = s.IsReadOnly = true;
                int hours = Convert.ToInt32(h.Text);
                int seconds = Convert.ToInt32(s.Text);
                int minutes = Convert.ToInt32(m.Text);
                _time = new TimeSpan(hours, minutes, seconds);
                _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
                {
                    h.Text = _time.Hours.ToString();
                    m.Text = _time.Minutes.ToString();
                    s.Text = _time.Seconds.ToString();
                    if (_time == TimeSpan.Zero) _timer.Stop();
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                }, Application.Current.Dispatcher);

                /// _timer.Start();
            }
            else
            {
                _timer.Stop();
                h.IsReadOnly = m.IsReadOnly = s.IsReadOnly = false;
                buttom.Fill = Brushes.Red;
            }
        }
        public void Reset()
        {
            _timer.Stop();
            h.Text = m.Text = s.Text = "0";
        }

    }
}
