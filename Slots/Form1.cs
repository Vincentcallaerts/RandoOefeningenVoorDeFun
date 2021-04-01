using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slots
{
    public partial class Form1 : Form
    {
        List<TextBox> slots;
        public Form1()
        {
            slots = new List<TextBox>();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
