namespace Horloge
{
    partial class Horloge
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horloge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butArretPc = new System.Windows.Forms.Button();
            this.butReveil = new System.Windows.Forms.Button();
            this.butHorloge = new System.Windows.Forms.Button();
            this.butMinuteur = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularHorloge = new CircularProgressBar.CircularProgressBar();
            this.timerHorloge = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picShutPC = new System.Windows.Forms.PictureBox();
            this.pictMinuteur = new System.Windows.Forms.PictureBox();
            this.pictReveil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShutPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinuteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReveil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(682, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.butArretPc);
            this.panel2.Controls.Add(this.butReveil);
            this.panel2.Controls.Add(this.butHorloge);
            this.panel2.Controls.Add(this.butMinuteur);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 340);
            this.panel2.TabIndex = 1;
            // 
            // butArretPc
            // 
            this.butArretPc.FlatAppearance.BorderSize = 0;
            this.butArretPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butArretPc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butArretPc.ForeColor = System.Drawing.Color.White;
            this.butArretPc.Image = ((System.Drawing.Image)(resources.GetObject("butArretPc.Image")));
            this.butArretPc.Location = new System.Drawing.Point(0, 162);
            this.butArretPc.Name = "butArretPc";
            this.butArretPc.Size = new System.Drawing.Size(160, 40);
            this.butArretPc.TabIndex = 13;
            this.butArretPc.Text = "      Arret PC     ";
            this.butArretPc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butArretPc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butArretPc.UseVisualStyleBackColor = true;
            this.butArretPc.Click += new System.EventHandler(this.butArretPc_Click);
            // 
            // butReveil
            // 
            this.butReveil.FlatAppearance.BorderSize = 0;
            this.butReveil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReveil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReveil.ForeColor = System.Drawing.Color.White;
            this.butReveil.Image = ((System.Drawing.Image)(resources.GetObject("butReveil.Image")));
            this.butReveil.Location = new System.Drawing.Point(0, 122);
            this.butReveil.Name = "butReveil";
            this.butReveil.Size = new System.Drawing.Size(160, 40);
            this.butReveil.TabIndex = 12;
            this.butReveil.Text = "      Réveil          ";
            this.butReveil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butReveil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butReveil.UseVisualStyleBackColor = true;
            this.butReveil.Click += new System.EventHandler(this.butReveil_Click);
            // 
            // butHorloge
            // 
            this.butHorloge.FlatAppearance.BorderSize = 0;
            this.butHorloge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHorloge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHorloge.ForeColor = System.Drawing.Color.White;
            this.butHorloge.Image = ((System.Drawing.Image)(resources.GetObject("butHorloge.Image")));
            this.butHorloge.Location = new System.Drawing.Point(0, 42);
            this.butHorloge.Name = "butHorloge";
            this.butHorloge.Size = new System.Drawing.Size(160, 40);
            this.butHorloge.TabIndex = 10;
            this.butHorloge.Text = "       Horloge     ";
            this.butHorloge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butHorloge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butHorloge.UseVisualStyleBackColor = true;
            this.butHorloge.Click += new System.EventHandler(this.butHorloge_Click);
            // 
            // butMinuteur
            // 
            this.butMinuteur.FlatAppearance.BorderSize = 0;
            this.butMinuteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMinuteur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinuteur.ForeColor = System.Drawing.Color.White;
            this.butMinuteur.Image = ((System.Drawing.Image)(resources.GetObject("butMinuteur.Image")));
            this.butMinuteur.Location = new System.Drawing.Point(0, 82);
            this.butMinuteur.Name = "butMinuteur";
            this.butMinuteur.Size = new System.Drawing.Size(160, 40);
            this.butMinuteur.TabIndex = 11;
            this.butMinuteur.Text = "       Minuteur     ";
            this.butMinuteur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butMinuteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butMinuteur.UseVisualStyleBackColor = true;
            this.butMinuteur.Click += new System.EventHandler(this.butMinuteur_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(46, 258);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(67, 58);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictReveil);
            this.panel3.Controls.Add(this.pictMinuteur);
            this.panel3.Controls.Add(this.picShutPC);
            this.panel3.Controls.Add(this.circularHorloge);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(160, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 340);
            this.panel3.TabIndex = 2;
            // 
            // circularHorloge
            // 
            this.circularHorloge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularHorloge.AnimationSpeed = 100;
            this.circularHorloge.BackColor = System.Drawing.Color.Transparent;
            this.circularHorloge.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularHorloge.ForeColor = System.Drawing.Color.Blue;
            this.circularHorloge.InnerColor = System.Drawing.Color.Black;
            this.circularHorloge.InnerMargin = 2;
            this.circularHorloge.InnerWidth = -1;
            this.circularHorloge.Location = new System.Drawing.Point(126, 8);
            this.circularHorloge.MarqueeAnimationSpeed = 2000;
            this.circularHorloge.Maximum = 60;
            this.circularHorloge.Name = "circularHorloge";
            this.circularHorloge.OuterColor = System.Drawing.Color.Black;
            this.circularHorloge.OuterMargin = -25;
            this.circularHorloge.OuterWidth = 26;
            this.circularHorloge.ProgressColor = System.Drawing.Color.Blue;
            this.circularHorloge.ProgressWidth = 25;
            this.circularHorloge.SecondaryFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularHorloge.Size = new System.Drawing.Size(320, 320);
            this.circularHorloge.StartAngle = 270;
            this.circularHorloge.Step = 1;
            this.circularHorloge.SubscriptColor = System.Drawing.Color.Red;
            this.circularHorloge.SubscriptMargin = new System.Windows.Forms.Padding(-142, 30, 0, 0);
            this.circularHorloge.SubscriptText = "57";
            this.circularHorloge.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularHorloge.SuperscriptMargin = new System.Windows.Forms.Padding(20, 40, 0, 0);
            this.circularHorloge.SuperscriptText = "";
            this.circularHorloge.TabIndex = 0;
            this.circularHorloge.TextMargin = new System.Windows.Forms.Padding(20, 8, 0, 0);
            this.circularHorloge.Value = 60;
            // 
            // timerHorloge
            // 
            this.timerHorloge.Enabled = true;
            this.timerHorloge.Interval = 250;
            this.timerHorloge.Tick += new System.EventHandler(this.timerHorloge_Tick);
            // 
            // picShutPC
            // 
            this.picShutPC.Image = ((System.Drawing.Image)(resources.GetObject("picShutPC.Image")));
            this.picShutPC.Location = new System.Drawing.Point(234, 82);
            this.picShutPC.Name = "picShutPC";
            this.picShutPC.Size = new System.Drawing.Size(25, 25);
            this.picShutPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShutPC.TabIndex = 1;
            this.picShutPC.TabStop = false;
            this.picShutPC.Visible = false;
            // 
            // pictMinuteur
            // 
            this.pictMinuteur.Image = ((System.Drawing.Image)(resources.GetObject("pictMinuteur.Image")));
            this.pictMinuteur.Location = new System.Drawing.Point(277, 82);
            this.pictMinuteur.Name = "pictMinuteur";
            this.pictMinuteur.Size = new System.Drawing.Size(25, 25);
            this.pictMinuteur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictMinuteur.TabIndex = 1;
            this.pictMinuteur.TabStop = false;
            this.pictMinuteur.Visible = false;
            // 
            // pictReveil
            // 
            this.pictReveil.Image = ((System.Drawing.Image)(resources.GetObject("pictReveil.Image")));
            this.pictReveil.Location = new System.Drawing.Point(319, 82);
            this.pictReveil.Name = "pictReveil";
            this.pictReveil.Size = new System.Drawing.Size(25, 25);
            this.pictReveil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictReveil.TabIndex = 1;
            this.pictReveil.TabStop = false;
            this.pictReveil.Visible = false;
            // 
            // Horloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Horloge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Horloge_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShutPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinuteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictReveil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerHorloge;
        public CircularProgressBar.CircularProgressBar circularHorloge;
        private System.Windows.Forms.Button butMinuteur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button butArretPc;
        private System.Windows.Forms.Button butReveil;
        private System.Windows.Forms.Button butHorloge;
        private System.Windows.Forms.PictureBox pictReveil;
        private System.Windows.Forms.PictureBox pictMinuteur;
        private System.Windows.Forms.PictureBox picShutPC;
    }
}

