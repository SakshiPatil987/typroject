using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typroject
{
    public partial class BloodTest : Form
    {
        public string TestName { get; set; }
        public string Result { get; set; }
        public string ReferenceRange { get; set; }
        public string Flag { get; set; }
        public BloodTest()
        {
            InitializeComponent();
        }

        private void BloodTest_Load(object sender, EventArgs e)
        {

        }
    }
}
