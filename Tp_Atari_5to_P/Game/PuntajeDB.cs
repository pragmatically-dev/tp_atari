using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Tp_Atari_5to_P
{
    public class Jugador {

        public string Nombre { get; set; }
        public int Puntaje { get; set; }
        public string Fecha { get; set; }
    }
   public class PuntajeDB
    {
       private SQLiteConnection conn;
       private SQLiteCommand cmd;
       private string ConString ="Data Source=Puntuaciones.db";
       private string Ruta = "Puntuaciones.db";
        public void GenerarDB()
        {
            if (!File.Exists(Ruta))
            {
                SQLiteConnection.CreateFile(Ruta);
                conn = new SQLiteConnection(ConString);
                conn.Open();
                string sql = "CREATE TABLE Jugadores(Nombre TEXT,Puntos INTEGER,Fecha TEXT)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void InsertarPuntaje(Jugador Entidad) {          
           
                conn = new SQLiteConnection(ConString);
                conn.Open();
                cmd = new SQLiteCommand("INSERT INTO Jugadores (Nombre,Puntos,Fecha) VALUES (@NOM,@PUNTOS,@FECHA)", conn);
                cmd.Parameters.AddWithValue("NOM",Entidad.Nombre);
                cmd.Parameters.AddWithValue("PUNTOS",Entidad.Puntaje.ToString());
                cmd.Parameters.AddWithValue("FECHA",Entidad.Fecha);
                cmd.ExecuteNonQuery();
                conn.Close();   
        }

        public List<Jugador> LeerPuntajes(List<Jugador> jugadores) {

            conn = new SQLiteConnection(ConString);
            conn.Open();
            cmd = new SQLiteCommand("SELECT * FROM Jugadores ORDER BY Puntos DESC", conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            jugadores = new List<Jugador>();
            while (dr.Read())
            {
                jugadores.Add(new Jugador
                {
                    Nombre = dr["Nombre"].ToString(),
                    Puntaje = Convert.ToInt32(dr["Puntos"]),
                    Fecha = dr["Fecha"].ToString()

                }) ;
            }
            conn.Close();
            return jugadores;
       
        }


    }
}
