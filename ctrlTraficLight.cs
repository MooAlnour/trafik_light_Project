using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class ctrlTraficLight: UserControl
    {
        public ctrlTraficLight()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
        }

        public enum enTrafficLight { Red = 0, Orange = 1, Green = 2 };
        enTrafficLight _CurrentLight = enTrafficLight.Red;

        public class TraficLightEventArgs : EventArgs
        {
            public enTrafficLight CurrentLight { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(enTrafficLight CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }

        }

        /// <summary>
        /// RedLight Event
        /// </summary>
        public event EventHandler<TraficLightEventArgs> RedLightOn;

        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enTrafficLight.Red, _redTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        /// <summary>
        /// GreenLight Event
        /// </summary>

        public event EventHandler<TraficLightEventArgs> GreenLightOn;

        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enTrafficLight.Green, _greenTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        /// <summary>
        /// Orange light Event
        /// </summary>

        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(enTrafficLight.Orange, _orangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }

        private int _CurrentCountDownValue;

        private int _greenTime = 5;

        private int _orangeTime = 5;

        private int _redTime = 2;

        public enTrafficLight CurrentLight
        {
            get
            {
                return _CurrentLight;
            }
            set
            {
                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enTrafficLight.Red:
                        pbLight.Image = Resources.Red;
                        lblTime.ForeColor = Color.Red;
                        //  _CurrentCountDownValue = RedTime;
                        //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                    case enTrafficLight.Orange:
                        pbLight.Image = Resources.Orange;
                        lblTime.ForeColor = Color.Orange;
                        break;
                    case enTrafficLight.Green:
                        pbLight.Image = Resources.Green;
                        lblTime.ForeColor = Color.Green;
                        // _CurrentCountDownValue = GreenTime;
                        //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                    default:
                        lblTime.ForeColor = Color.Red;
                        // _CurrentCountDownValue = RedTime;
                        //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;

                }


            }

        }
        public int OrangeTime
        {
            get
            {
                return _orangeTime;
            }
            set
            {
                _orangeTime = value;
            }
        }
        public int RedTime
        {
            get
            {
                return _redTime;
            }
            set
            {
                _redTime = value;
            }
        }
        public int GreenTime
        {
            get
            {
                return _greenTime;
            }
            set
            {
                _greenTime = value;
            }
        }

        public int GetCurrentTime()
        {

            switch (_CurrentLight)
            {
                case enTrafficLight.Orange:
                    return OrangeTime;

                case enTrafficLight.Green:
                    return GreenTime;
                case enTrafficLight.Red:
                    return RedTime;
                default: return RedTime;
            }

        }

        public void Start()
        {
            timer1.Start();

            _CurrentCountDownValue = GetCurrentTime();
        }

        private enTrafficLight _LightAfterOrangeGreenOrRed;

        private void _ChangeLight()
        {
            CurrentLight = GetNextLight(CurrentLight);
            _CurrentCountDownValue = GetCurrentTime();
            lblTime.Text = _CurrentCountDownValue.ToString();
            RaiseEventForCurrentLight();
        }
        private enTrafficLight GetNextLight(enTrafficLight current)
        {
            return current == enTrafficLight.Red ? enTrafficLight.Green :
                current == enTrafficLight.Green ? enTrafficLight.Orange :
                enTrafficLight.Red;
        }
        private void RaiseEventForCurrentLight()
        {
            switch (CurrentLight)
            {
                case enTrafficLight.Red:
                    RaiseRedLightOn();
                    break;
                case enTrafficLight.Green:
                    RaiseGreenLightOn();
                    break;
                case enTrafficLight.Orange:
                    RaiseOrangeLightOn();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue == 0)
            {
                _ChangeLight();
            }
            else
            {
                --_CurrentCountDownValue;
            }
        }
    }

}
    