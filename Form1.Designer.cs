namespace PiggyCatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Piggy1 = new System.Windows.Forms.PictureBox();
            this.Piggy4 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtMiss = new System.Windows.Forms.Label();
            this.BigPiggy1 = new System.Windows.Forms.PictureBox();
            this.Piggy5 = new System.Windows.Forms.PictureBox();
            this.Piggy6 = new System.Windows.Forms.PictureBox();
            this.Piggy7 = new System.Windows.Forms.PictureBox();
            this.Piggy2 = new System.Windows.Forms.PictureBox();
            this.Piggy3 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BigPiggy2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPiggy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPiggy2)).BeginInit();
            this.SuspendLayout();
            // 
            // Piggy1
            // 
            this.Piggy1.Image = ((System.Drawing.Image)(resources.GetObject("Piggy1.Image")));
            this.Piggy1.Location = new System.Drawing.Point(283, 12);
            this.Piggy1.Name = "Piggy1";
            this.Piggy1.Size = new System.Drawing.Size(83, 66);
            this.Piggy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy1.TabIndex = 2;
            this.Piggy1.TabStop = false;
            this.Piggy1.Tag = "Piggy";
            // 
            // Piggy4
            // 
            this.Piggy4.Image = ((System.Drawing.Image)(resources.GetObject("Piggy4.Image")));
            this.Piggy4.Location = new System.Drawing.Point(358, 21);
            this.Piggy4.Name = "Piggy4";
            this.Piggy4.Size = new System.Drawing.Size(84, 66);
            this.Piggy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy4.TabIndex = 6;
            this.Piggy4.TabStop = false;
            this.Piggy4.Tag = "Piggy";
            // 
            // Player
            // 
            this.Player.Image = global::PiggyCatch.Properties.Resources.Егор;
            this.Player.Location = new System.Drawing.Point(369, 671);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(73, 98);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 8;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(27, 628);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(47, 13);
            this.txtScore.TabIndex = 9;
            this.txtScore.Text = "Score: 0";
            // 
            // txtMiss
            // 
            this.txtMiss.AutoSize = true;
            this.txtMiss.Location = new System.Drawing.Point(728, 628);
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(52, 13);
            this.txtMiss.TabIndex = 10;
            this.txtMiss.Text = "Missed: 0";
            // 
            // BigPiggy1
            // 
            this.BigPiggy1.Image = ((System.Drawing.Image)(resources.GetObject("BigPiggy1.Image")));
            this.BigPiggy1.Location = new System.Drawing.Point(1, 644);
            this.BigPiggy1.Name = "BigPiggy1";
            this.BigPiggy1.Size = new System.Drawing.Size(120, 139);
            this.BigPiggy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigPiggy1.TabIndex = 11;
            this.BigPiggy1.TabStop = false;
            // 
            // Piggy5
            // 
            this.Piggy5.Image = ((System.Drawing.Image)(resources.GetObject("Piggy5.Image")));
            this.Piggy5.Location = new System.Drawing.Point(86, 12);
            this.Piggy5.Name = "Piggy5";
            this.Piggy5.Size = new System.Drawing.Size(85, 66);
            this.Piggy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy5.TabIndex = 12;
            this.Piggy5.TabStop = false;
            this.Piggy5.Tag = "Piggy";
            // 
            // Piggy6
            // 
            this.Piggy6.Image = ((System.Drawing.Image)(resources.GetObject("Piggy6.Image")));
            this.Piggy6.Location = new System.Drawing.Point(493, 30);
            this.Piggy6.Name = "Piggy6";
            this.Piggy6.Size = new System.Drawing.Size(84, 66);
            this.Piggy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy6.TabIndex = 13;
            this.Piggy6.TabStop = false;
            this.Piggy6.Tag = "Piggy";
            // 
            // Piggy7
            // 
            this.Piggy7.Image = ((System.Drawing.Image)(resources.GetObject("Piggy7.Image")));
            this.Piggy7.Location = new System.Drawing.Point(423, 21);
            this.Piggy7.Name = "Piggy7";
            this.Piggy7.Size = new System.Drawing.Size(85, 66);
            this.Piggy7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy7.TabIndex = 14;
            this.Piggy7.TabStop = false;
            this.Piggy7.Tag = "Piggy";
            // 
            // Piggy2
            // 
            this.Piggy2.Image = ((System.Drawing.Image)(resources.GetObject("Piggy2.Image")));
            this.Piggy2.Location = new System.Drawing.Point(560, 21);
            this.Piggy2.Name = "Piggy2";
            this.Piggy2.Size = new System.Drawing.Size(84, 66);
            this.Piggy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy2.TabIndex = 15;
            this.Piggy2.TabStop = false;
            this.Piggy2.Tag = "Piggy";
            // 
            // Piggy3
            // 
            this.Piggy3.Image = ((System.Drawing.Image)(resources.GetObject("Piggy3.Image")));
            this.Piggy3.Location = new System.Drawing.Point(192, 12);
            this.Piggy3.Name = "Piggy3";
            this.Piggy3.Size = new System.Drawing.Size(85, 66);
            this.Piggy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piggy3.TabIndex = 16;
            this.Piggy3.TabStop = false;
            this.Piggy3.Tag = "Piggy";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGamerTimerEvnt);
            // 
            // BigPiggy2
            // 
            this.BigPiggy2.Image = ((System.Drawing.Image)(resources.GetObject("BigPiggy2.Image")));
            this.BigPiggy2.Location = new System.Drawing.Point(683, 644);
            this.BigPiggy2.Name = "BigPiggy2";
            this.BigPiggy2.Size = new System.Drawing.Size(120, 139);
            this.BigPiggy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigPiggy2.TabIndex = 17;
            this.BigPiggy2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 781);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtMiss);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Piggy3);
            this.Controls.Add(this.Piggy2);
            this.Controls.Add(this.Piggy7);
            this.Controls.Add(this.Piggy6);
            this.Controls.Add(this.Piggy5);
            this.Controls.Add(this.Piggy4);
            this.Controls.Add(this.Piggy1);
            this.Controls.Add(this.BigPiggy1);
            this.Controls.Add(this.BigPiggy2);
            this.Name = "Form1";
            this.Text = "Catch a piggy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Piggy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPiggy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piggy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigPiggy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Piggy4;
        private System.Windows.Forms.PictureBox Piggy1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtMiss;
        private System.Windows.Forms.PictureBox BigPiggy1;
        private System.Windows.Forms.PictureBox Piggy5;
        private System.Windows.Forms.PictureBox Piggy6;
        private System.Windows.Forms.PictureBox Piggy7;
        private System.Windows.Forms.PictureBox Piggy2;
        private System.Windows.Forms.PictureBox Piggy3;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox BigPiggy2;
    }
}

