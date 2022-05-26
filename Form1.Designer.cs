
namespace game
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greenCar = new System.Windows.Forms.PictureBox();
            this.redCar = new System.Windows.Forms.PictureBox();
            this.playerCar = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.greenCar);
            this.panel1.Controls.Add(this.redCar);
            this.panel1.Controls.Add(this.playerCar);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 593);
            this.panel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(179, 643);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(134, 57);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(179, 608);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLabel.Size = new System.Drawing.Size(134, 32);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::game.Properties.Resources.readme2;
            this.pictureBox3.Location = new System.Drawing.Point(477, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(866, 155);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::game.Properties.Resources.readme1;
            this.pictureBox2.Location = new System.Drawing.Point(477, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(847, 404);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox1.Image = global::game.Properties.Resources.readme;
            this.pictureBox1.Location = new System.Drawing.Point(477, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // greenCar
            // 
            this.greenCar.BackColor = System.Drawing.Color.Transparent;
            this.greenCar.Image = global::game.Properties.Resources.carGreen;
            this.greenCar.Location = new System.Drawing.Point(328, 40);
            this.greenCar.Name = "greenCar";
            this.greenCar.Size = new System.Drawing.Size(50, 101);
            this.greenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenCar.TabIndex = 7;
            this.greenCar.TabStop = false;
            this.greenCar.Tag = "carRight";
            // 
            // redCar
            // 
            this.redCar.BackColor = System.Drawing.Color.Transparent;
            this.redCar.Image = global::game.Properties.Resources.CarRed;
            this.redCar.Location = new System.Drawing.Point(82, 40);
            this.redCar.Name = "redCar";
            this.redCar.Size = new System.Drawing.Size(50, 100);
            this.redCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redCar.TabIndex = 6;
            this.redCar.TabStop = false;
            this.redCar.Tag = "carLeft";
            // 
            // playerCar
            // 
            this.playerCar.BackColor = System.Drawing.Color.Transparent;
            this.playerCar.Image = global::game.Properties.Resources.carPink;
            this.playerCar.Location = new System.Drawing.Point(215, 433);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(50, 100);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerCar.TabIndex = 5;
            this.playerCar.TabStop = false;
            this.playerCar.Tag = "player";
            // 
            // road2
            // 
            this.road2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.road2.Image = global::game.Properties.Resources.roadTrack5;
            this.road2.Location = new System.Drawing.Point(0, 0);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(469, 593);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 4;
            this.road2.TabStop = false;
            // 
            // road1
            // 
            this.road1.Image = global::game.Properties.Resources.roadTrack5;
            this.road1.Location = new System.Drawing.Point(0, -593);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(469, 593);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 3;
            this.road1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "THE CAR RACING GAME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox greenCar;
        private System.Windows.Forms.PictureBox redCar;
        private System.Windows.Forms.PictureBox playerCar;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

