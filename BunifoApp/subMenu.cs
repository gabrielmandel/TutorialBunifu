using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace BunifoApp
{
    public partial class subMenu : UserControl
    {
        public subMenu()
        {
            InitializeComponent();

            VSReactive<int>.Subscribe("menu", e => subMenus.SelectedIndex = e);
        }

        private void subMenu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
