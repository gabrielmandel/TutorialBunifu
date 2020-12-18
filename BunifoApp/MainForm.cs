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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

           // btnDashboard.Click += menuLateral_Click;




        }

        bool menuAumentado = false;
        private void DetectaMouse_Tick(object sender, EventArgs e)
        {
            //Detecta o mouse dentro do painel do menu
            //Aumenta o menu com animação
            //Caso contrário o menu diminui com animação
            //if (!bunifuTransition1.IsCompleted) return;
            
            if (pnlMenuPrincipal.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                   if (!menuAumentado)
                {
                    menuAumentado = true;
                    pnlMenuPrincipal.Width = 190;
                }
            }
            else
            {
                if (menuAumentado)
                {
                    menuAumentado = false;
                    pnlMenuPrincipal.Width = 47;
                    bunifuTransition1.Show(pnlMenuPrincipal);
                }
            }
        }

        private void menuLateral_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

       
    }
}
