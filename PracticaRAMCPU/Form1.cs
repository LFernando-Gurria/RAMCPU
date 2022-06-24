using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace PracticaRAMCPU
{
    public partial class Barra : MetroFramework.Forms.MetroForm
    {
        public Barra()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            barCPU.Value = (int)fcpu;
            barRAM.Value = (int)fram;
            lblCPU.Text = String.Format("{0:0.00}%", fcpu);
            lblRAM.Text = String.Format("{0:0.00}%", fram);

            chart1.Series["CPU use"].Points.AddY(fcpu);
            chart1.Series["RAM use"].Points.AddY(fram);






        }


        protected void activarNotificasion(EventArgs e)
        {
            notificacion.Visible = true;
            notificacion.ShowBalloonTip(0);

        }

        private void notificacion_BalloonTipClicked(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            notificacion.Visible = false;
           
        }
        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            notificacion.Visible = false;
          
        }

        private void restablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            notificacion.Visible = false;
         
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Minimized)
                activarNotificasion(e);
            base.OnClientSizeChanged(e);
            ShowInTaskbar = true;





        }







        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
          
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
           





        }

        private void Barra_Load(object sender, EventArgs e)
        {

        }








      
    }
}
