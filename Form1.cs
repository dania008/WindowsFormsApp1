using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Comment
        // Comment
        MyProcess myProcess = new MyProcess();
        public Form1()
        {
            InitializeComponent();
            myProcess.callEvent += setProgressBar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myProcess.StartProcess();
        }
        public void setProgressBar(int val)
        {
            progressBar1.Value = val;
        }
    }
    public class MyProcess
    {
        public delegate void Mydelegate(int par);
        public event Mydelegate callEvent;
        public void StartProcess()
        {
            for (int i = 0; i < 101; i++)
            {
                callEvent(i);
                Thread.Sleep(100);
            }
        }
    }
}
