using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QIX.BiblePTT
{
    public partial class fmAbout : Form
    {
        public fmAbout()
        {
            InitializeComponent();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenLink(label6.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenLink(label7.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            OpenLink(label8.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenLink(label6.Text);
        }

        private void OpenLink(string url)
        {
            if (url.StartsWith("www."))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
    }
}
