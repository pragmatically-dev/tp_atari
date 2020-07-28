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
using System.Media;
namespace Tp_Atari_5to_P
{
    public partial class Juego : Form
    {

        #region"Variables"
        protected PictureBox[,] bloques = new PictureBox[13, 8];
       // public List<PictureBox> bloques = new List<PictureBox>();
        protected bool left=false, right=false;//para e movimiento de raqueta
        protected bool arriba, izquierda;//para movimiento de la pelota
        protected int speedR=300;
        protected int speedP = 15;
        protected int Puntos;
        protected int count;
        private PuntajeDB PuntajeDB = new PuntajeDB();//Manejo de la db
        private SoundPlayer Barra= new SoundPlayer(Application.StartupPath+@"/Choque_barra.wav");
        private SoundPlayer Rbloque = new SoundPlayer(Application.StartupPath + @"/Rompe_bloque.wav");
        private SoundPlayer choque_l = new SoundPlayer(Application.StartupPath + @"/Punto.wav");
        #endregion

        public void Bloques()//Esta funcion se encarga de generar los bloques
        {

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    bloques[x, y] = new PictureBox();
                    bloques[x, y].BackColor = Color.Brown;
                    bloques[x, y].Size = new System.Drawing.Size(150, 30);
                    bloques[x, y].Location = new System.Drawing.Point(x * 151, y * 31);
                    this.Controls.Add(bloques[x, y]);
                }
            }
        }
        public void Resetear() {
      
            Application.Restart();
        }
        public void ComprobarColisionBarra() {
            if (Raqueta.Bounds.IntersectsWith(Pelota.Bounds)) {
                count++;
                arriba = false;
                Barra.Play();
            }
        }
       
        public void  ComprobarColision()
        {

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    if (bloques[x, y].Enabled == false){}
                    else if(Pelota.Bounds.IntersectsWith(bloques[x, y].Bounds))
                    {
                        bloques[x, y].Hide();
                        bloques[x, y].Enabled=false;
                        //Beep();
                        Puntos += 1;
                        this.Text = "Puntaje: " + Puntos;
                        speedP =17;
                        arriba = true;
                        Rbloque.Play();
                    }
                }
            }
            //if (Pelota.Top < -100) {
            //    arriba = false;
            //}
        }
        public Juego()
        {
            InitializeComponent();
            Bloques();
            Game.Enabled = true;
            Colisiones.Enabled = true;
        }

        private void Colisiones_Tick(object sender, EventArgs e)
        {
            ComprobarColision();
            ComprobarColisionBarra();
           
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            PuntajeDB.GenerarDB();
        }

        private void Juego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Raqueta_Click(object sender, EventArgs e)
        {

        }

        private void Juego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                right = true;
                left = false;
                speedR = 22;
            }
            if (e.KeyCode == Keys.Left)
            {
                right = false;
                left = true;
                speedR = 22;
            }
            if (e.KeyCode == Keys.Down)
            {
                speedR = 0;

            }
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            #region"Movimiento de raqueta"
            if (right){Raqueta.Left += speedR;}
            if (left) {  Raqueta.Left -= speedR; }
            if (Raqueta.Left < 19) { speedR = 0; }
            if (Raqueta.Left >  (this.Width-30)-Raqueta.Width) { speedR = 0; }
            #endregion
            #region"Game Over"
           // Se termina el juego
            if (Pelota.Top > Raqueta.Top)
            {
                Game.Stop();
                Colisiones.Stop();
                Jugador jugador = new Jugador();
                panel1.Visible = true;
                MessageBox.Show("Perdiste!! tu puntaje es de "+Puntos,"Game Over");
                jugador.Nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su Nombre", "Game Over");
                jugador.Puntaje = Puntos;
                jugador.Fecha = DateTime.Now.ToString();
                PuntajeDB.InsertarPuntaje(jugador);
            }

            #endregion
            #region"Movimiento de pelota"
            //Mover pelota
            Pelota.Top = (!arriba) ? Pelota.Top -= speedP : Pelota.Top += speedP;
            Pelota.Left = (!izquierda) ? Pelota.Left -= speedP : Pelota.Left += speedP;
            if (Pelota.Left <= 0) {
                izquierda = true;
                choque_l.Play();
            }
            if (Pelota.Left >= this.Width - 30) {
                izquierda = false;
                choque_l.Play();
            }
            if (Pelota.Top >= 560) {
                arriba = false;
                choque_l.Play();
            }
            #endregion
        }
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
      
            if (e.KeyCode==Keys.Enter) {
                Resetear();
            }

        }


    }
}
