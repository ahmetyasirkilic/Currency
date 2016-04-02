/*
 * .:: Created by Elnino ::.
 * .:: manilaorleans@gmail.com ::.
 */

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Transitions;

namespace doviz
{
    public partial class FormMain : Form
    {
        #region HideApp
        // Hide app from Alt+Tab
        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x80;
                return Params;
            }
        } 
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        enum TransitionPropertyNames
        { 
            Text,
            ForeColor,
            BackColor,
            Left,
            Top
        }

        private string _usd;
        private static int SCREEN_WIDTH = SystemInformation.VirtualScreen.Width;
        private bool _onDrag;
        private Point _oldPosition, a;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                HtmlElementCollection links = webBrowser1.Document.GetElementsByTagName("td");
                foreach (HtmlElement link in links)
                {
                    if (link.GetAttribute("className") == "deger")
                    {
                        _usd = link.InnerHtml;
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            Transition.run(lblUsdValue, TransitionPropertyNames.Text.ToString(), _usd, new TransitionType_Linear(500));
            Animation(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(SCREEN_WIDTH - this.Width, 0 - this.Height);
        }

        private void Animation()
        {
            Transition.run(this, TransitionPropertyNames.Top+"", 50, new TransitionType_CriticalDamping(1000));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _onDrag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - _oldPosition.X, 50);
                if (p.X < a.X - 50)
                {
                    ClosingAnimation(0 - this.Width);
                }
                if (p.X > a.X + 10)
                {
                    ClosingAnimation(SCREEN_WIDTH + this.Width);
                }
            }
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _onDrag = true;
            _oldPosition = e.Location;
            a = PointToScreen(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _onDrag = false;
            try
            {
                GC.Collect(); // Collect Garbage
                GC.WaitForPendingFinalizers();  // Fire Garbage
            }
            catch (Exception) { }
        }

        void ClosingAnimation(object destinationValue)
        {
            _onDrag = false;
            Transition t = new Transition(new TransitionType_CriticalDamping(500));
            t.add(this, "Left", destinationValue);
            t.run();
            t.TransitionCompletedEvent += new EventHandler<Transition.Args>(t_TransitionCompletedEvent);
        }

        static void t_TransitionCompletedEvent(object sender, Transition.Args e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception){
            }
        }

    }
}
