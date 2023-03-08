using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberHW_Photo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler ChosePhotoSizeEvent = null;
        public event EventHandler UserEvent = null;

        private void radioButton_9_12_CheckedChanged(object sender, EventArgs e)
        {
            UserEvent.Invoke(sender, e);
        }

        private void radioButton_12_15_CheckedChanged(object sender, EventArgs e)
        {
            UserEvent.Invoke(sender, e);
        }

        private void radioButton_18_24_CheckedChanged(object sender, EventArgs e)
        {
            UserEvent.Invoke(sender, e);
        }

        private void textBox_num_TextChanged(object sender, EventArgs e)
        {
            UserEvent.Invoke(sender, e);
        }
    }
}
