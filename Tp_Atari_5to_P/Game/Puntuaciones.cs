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
    public partial class Puntuaciones : Form
    {
        public Puntuaciones()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Puntuaciones_Load(object sender, EventArgs e)
        {
            PuntajeDB puntajeDB = new PuntajeDB();
            List<Jugador> player = new List<Jugador>();
            player = puntajeDB.LeerPuntajes(player);
            dg1.DataSource=player;
            
        }
    }
}
