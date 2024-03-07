using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class komputer : Form
    {
        Form1=ParenthesizePropertyNameAttribute;
            komputer(Form1 stare_okno)
        {
            Parent = stare_okno;
        }

        public komputer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

