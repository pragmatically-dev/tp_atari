namespace Tp_Atari_5to_P
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.Colisiones = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pelota = new System.Windows.Forms.PictureBox();
            this.Raqueta = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // Game
            // 
            this.Game.Enabled = true;
            this.Game.Interval = 20;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // Colisiones
            // 
            this.Colisiones.Interval = 10;
            this.Colisiones.Tick += new System.EventHandler(this.Colisiones_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 566);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presiona Enter para continuar...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tp_Atari_5to_P.Properties.Resources.Gameover1;
            this.pictureBox1.Location = new System.Drawing.Point(83, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pelota
            // 
            this.Pelota.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Pelota.Location = new System.Drawing.Point(499, 518);
            this.Pelota.Name = "Pelota";
            this.Pelota.Size = new System.Drawing.Size(17, 17);
            this.Pelota.TabIndex = 1;
            this.Pelota.TabStop = false;
            // 
            // Raqueta
            // 
            this.Raqueta.BackColor = System.Drawing.Color.White;
            this.Raqueta.Location = new System.Drawing.Point(358, 539);
            this.Raqueta.Name = "Raqueta";
            this.Raqueta.Size = new System.Drawing.Size(300, 20);
            this.Raqueta.TabIndex = 0;
            this.Raqueta.TabStop = false;
            this.Raqueta.Click += new System.EventHandler(this.Raqueta_Click);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pelota);
            this.Controls.Add(this.Raqueta);
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Juego_FormClosed);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raqueta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Raqueta;
        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.PictureBox Pelota;
        private System.Windows.Forms.Timer Colisiones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}