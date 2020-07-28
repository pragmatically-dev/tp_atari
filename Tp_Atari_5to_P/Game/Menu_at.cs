using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_Atari_5to_P;
namespace Tp_Atari_5to_P
{
    public partial class Menu_at : Form
    {
        public Menu_at()
        {
            InitializeComponent();
        }

        private void NuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Juego game = new Juego();
            game.Show();
            this.Hide();


        }

      

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_at_Load(object sender, EventArgs e)
        {
            PuntajeDB puntajeDB = new PuntajeDB();
            puntajeDB.GenerarDB();
        }

        private void PuntuacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puntuaciones FormPuntuaciones = new Puntuaciones();
           
            FormPuntuaciones.MdiParent = this;
            
            FormPuntuaciones.Show();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ramiro Ahumada, Santiago Nieva, Alan Quinteros, Lucas Quint","Creadores");
        }
    }
}
