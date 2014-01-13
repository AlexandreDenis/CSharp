using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Isima.TD.Notepad
{
    public partial class MainForm : Form
    {
        string filePath = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog(this))
            {
                filePath = openFileDialog1.FileName;
                string contenu;
                FileStream logFile = File.OpenRead(filePath);
                StreamReader sr = new StreamReader(logFile);

                contenu = sr.ReadToEnd();
                textBox1.Text = contenu;

                sr.Close();
                logFile.Close();
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog(this))
            {
                filePath = openFileDialog1.FileName;
                string contenu = textBox1.Text;
                FileStream logFile = File.Open(filePath, FileMode.Truncate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(logFile);

                sw.WriteLine(contenu);

                sw.Close();
                logFile.Close();
            }
        }
    }
}
