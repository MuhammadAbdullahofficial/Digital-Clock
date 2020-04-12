using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            AddApplicationToStartup();
            InitializeComponent();
            initData();
            initDesign();
            initLogic();
            textClockToolStripMenuItem.Checked = panel_top.Visible = false;
        }

        private void textClockToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            panel_top.Visible = textClockToolStripMenuItem.Checked;
        }

        private void panel_base_SizeChanged(object sender, EventArgs e)
        {
            if(clock_logic.Enabled)
                initDesign();
        }

        public static void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("DigitalClock_personal", "\"" + Application.ExecutablePath + "\"");
            }
        }
    }
}
