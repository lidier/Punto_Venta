﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_Venta
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                this.Tiempo.Stop();
                this.Close();
                
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
