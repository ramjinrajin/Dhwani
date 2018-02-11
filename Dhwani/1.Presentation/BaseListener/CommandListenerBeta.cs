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

namespace Dhwani._1.Presentation.BaseListener
{
    public partial class CommandListenerBeta : Form
    {
        public CommandListenerBeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "ഞാൻ".ToString())
            {
                textBox1.Text = textBox2.Text;
                MainModule();
            }
            else if (textBox1.Text == "കേരളം".ToString())
            {
                textBox1.Text = textBox3.Text;
                MainModule();
            }
            
        }

        private void MainModule()
        {
            List<char> listchar = new List<char>();

            for (int i = 0; i < textBox1.Text.ToString().Length; i++)
            {
                listchar.Add(textBox1.Text.ToString()[i]);
            }

            string MalayalamWord = "";
            for (int i = 0; i < listchar.Count; i++)
            {
                MalayalamWord = MalayalamWord + listchar[i];
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.co.in/search?query=" + MalayalamWord);
                if (listchar.Count - 1 == i)
                {
                    Process.Start(sInfo);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
