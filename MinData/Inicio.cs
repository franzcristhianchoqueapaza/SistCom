﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinData
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FrOpen = Application.OpenForms["frmRegistroPesaje"];
            if (FrOpen == null)
            {
                frmRegistroPesaje frm = new frmRegistroPesaje();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
