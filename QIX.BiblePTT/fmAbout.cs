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
            labelName.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            labelName.BackColor = Color.Transparent;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            lbFacebook.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            lbFacebook.BackColor = Color.Transparent;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            lbGithub.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            lbGithub.BackColor = Color.Transparent;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            lbEmail.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            lbEmail.BackColor = Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenLink(lbFacebook.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenLink(lbGithub.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            OpenLink(lbEmail.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenLink(lbFacebook.Text);
        }

        private void OpenLink(string url)
        {
            if (url.StartsWith("www."))
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void lbWebsite_MouseHover(object sender, EventArgs e)
        {
            lbGithub.BackColor = Color.FromArgb(111, 188, 173);
        }

        private void lbWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            OpenLink(lbWebsite.Text);
        }

        private void lbWebsite_MouseLeave(object sender, EventArgs e)
        {
            lbEmail.BackColor = Color.Transparent;
        }
    }
}
