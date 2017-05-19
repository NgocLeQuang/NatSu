using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Natsu.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);
    public partial class UcNatsuItem : UserControl
    {
        public event AllTextChange Changed;
        public UcNatsuItem()
        {
            InitializeComponent();
        }
    }
}
