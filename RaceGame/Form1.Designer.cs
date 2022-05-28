
namespace RaceGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Trophy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.Distance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Distance);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 648);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Trophy);
            this.panel2.Controls.Add(this.Player);
            this.panel2.Controls.Add(this.Explosion);
            this.panel2.Controls.Add(this.AI2);
            this.panel2.Controls.Add(this.AI1);
            this.panel2.Controls.Add(this.RoadTrack2);
            this.panel2.Controls.Add(this.RoadTrack1);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 591);
            this.panel2.TabIndex = 2;
            // 
            // Trophy
            // 
            this.Trophy.BackColor = System.Drawing.Color.Transparent;
            this.Trophy.Image = global::RaceGame.Properties.Resources.bronze;
            this.Trophy.Location = new System.Drawing.Point(66, 255);
            this.Trophy.Name = "Trophy";
            this.Trophy.Size = new System.Drawing.Size(250, 100);
            this.Trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trophy.TabIndex = 8;
            this.Trophy.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::RaceGame.Properties.Resources.carOrange;
            this.Player.Location = new System.Drawing.Point(171, 472);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 101);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 7;
            this.Player.TabStop = false;
            // 
            // Explosion
            // 
            this.Explosion.BackColor = System.Drawing.Color.Transparent;
            this.Explosion.Image = global::RaceGame.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(77, 161);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Explosion.TabIndex = 6;
            this.Explosion.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::RaceGame.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(281, 124);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::RaceGame.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(66, 30);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::RaceGame.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(-2, 0);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(385, 632);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 3;
            this.RoadTrack2.TabStop = false;
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.BackColor = System.Drawing.SystemColors.Control;
            this.RoadTrack1.Image = global::RaceGame.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(-2, -632);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(385, 632);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 2;
            this.RoadTrack1.TabStop = false;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Distance.Location = new System.Drawing.Point(6, 602);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(229, 31);
            this.Distance.TabIndex = 1;
            this.Distance.Text = "Расстояние : 00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(217, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рестарт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 648);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Race Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StopCar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.PictureBox Trophy;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.Timer timer1;
    }
}

