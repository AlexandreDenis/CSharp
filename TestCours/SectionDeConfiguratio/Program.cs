using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

namespace SectionDeConfiguratio
{
    static class Program
    {
        private static System.Timers.Timer _timer;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CustomConfigurationSection customConfig = CustomConfigurationSection.GetSection();
            string title = customConfig.WindowsTitle;
            int delay = customConfig.Delay;
            string strColor = customConfig.BackColor;

            Form1 form = new Form1();
            form.Text = title;

            //timer
            _timer = new System.Timers.Timer(delay);
            _timer.Elapsed += new ElapsedEventHandler(shutWindow);
            _timer.Interval = delay*1000;
            _timer.Enabled = true;

            ColorConverter converter = new ColorConverter();
            Color color = (Color)converter.ConvertFromString(strColor);
            form.BackColor = color;

            Application.Run(form);
        }

        private static void shutWindow(object source, ElapsedEventArgs e)
        {
            Application.Exit();
        }

    }
}
