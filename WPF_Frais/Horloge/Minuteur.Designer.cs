namespace Horloge
{
    partial class Minuteur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minuteur));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPreProg = new System.Windows.Forms.GroupBox();
            this.radioBut45min = new System.Windows.Forms.RadioButton();
            this.radioBut30min = new System.Windows.Forms.RadioButton();
            this.radioBut15min = new System.Windows.Forms.RadioButton();
            this.radioBut10min = new System.Windows.Forms.RadioButton();
            this.radioBut5min = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPerso = new System.Windows.Forms.CheckBox();
            this.checkBoxPreProg = new System.Windows.Forms.CheckBox();
            this.groupBoxPerso = new System.Windows.Forms.GroupBox();
            this.butValid = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBoxPreProg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(217, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuteur";
            // 
            // groupBoxPreProg
            // 
            this.groupBoxPreProg.Controls.Add(this.radioBut45min);
            this.groupBoxPreProg.Controls.Add(this.radioBut30min);
            this.groupBoxPreProg.Controls.Add(this.radioBut15min);
            this.groupBoxPreProg.Controls.Add(this.radioBut10min);
            this.groupBoxPreProg.Controls.Add(this.radioBut5min);
            this.groupBoxPreProg.Enabled = false;
            this.groupBoxPreProg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPreProg.Location = new System.Drawing.Point(376, 92);
            this.groupBoxPreProg.Name = "groupBoxPreProg";
            this.groupBoxPreProg.Size = new System.Drawing.Size(162, 187);
            this.groupBoxPreProg.TabIndex = 1;
            this.groupBoxPreProg.TabStop = false;
            // 
            // radioBut45min
            // 
            this.radioBut45min.AutoSize = true;
            this.radioBut45min.ForeColor = System.Drawing.Color.Red;
            this.radioBut45min.Location = new System.Drawing.Point(27, 155);
            this.radioBut45min.Name = "radioBut45min";
            this.radioBut45min.Size = new System.Drawing.Size(109, 23);
            this.radioBut45min.TabIndex = 0;
            this.radioBut45min.TabStop = true;
            this.radioBut45min.Text = "45 minutes";
            this.radioBut45min.UseVisualStyleBackColor = true;
            // 
            // radioBut30min
            // 
            this.radioBut30min.AutoSize = true;
            this.radioBut30min.ForeColor = System.Drawing.Color.Red;
            this.radioBut30min.Location = new System.Drawing.Point(27, 124);
            this.radioBut30min.Name = "radioBut30min";
            this.radioBut30min.Size = new System.Drawing.Size(109, 23);
            this.radioBut30min.TabIndex = 0;
            this.radioBut30min.TabStop = true;
            this.radioBut30min.Text = "30 minutes";
            this.radioBut30min.UseVisualStyleBackColor = true;
            // 
            // radioBut15min
            // 
            this.radioBut15min.AutoSize = true;
            this.radioBut15min.ForeColor = System.Drawing.Color.Red;
            this.radioBut15min.Location = new System.Drawing.Point(27, 93);
            this.radioBut15min.Name = "radioBut15min";
            this.radioBut15min.Size = new System.Drawing.Size(109, 23);
            this.radioBut15min.TabIndex = 0;
            this.radioBut15min.TabStop = true;
            this.radioBut15min.Text = "15 minutes";
            this.radioBut15min.UseVisualStyleBackColor = true;
            // 
            // radioBut10min
            // 
            this.radioBut10min.AutoSize = true;
            this.radioBut10min.ForeColor = System.Drawing.Color.Red;
            this.radioBut10min.Location = new System.Drawing.Point(27, 62);
            this.radioBut10min.Name = "radioBut10min";
            this.radioBut10min.Size = new System.Drawing.Size(109, 23);
            this.radioBut10min.TabIndex = 0;
            this.radioBut10min.TabStop = true;
            this.radioBut10min.Text = "10 minutes";
            this.radioBut10min.UseVisualStyleBackColor = true;
            // 
            // radioBut5min
            // 
            this.radioBut5min.AutoSize = true;
            this.radioBut5min.ForeColor = System.Drawing.Color.Red;
            this.radioBut5min.Location = new System.Drawing.Point(27, 31);
            this.radioBut5min.Name = "radioBut5min";
            this.radioBut5min.Size = new System.Drawing.Size(100, 23);
            this.radioBut5min.TabIndex = 0;
            this.radioBut5min.TabStop = true;
            this.radioBut5min.Text = "5 minutes";
            this.radioBut5min.UseVisualStyleBackColor = true;
            this.radioBut5min.CheckedChanged += new System.EventHandler(this.radioBut5min_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(172, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinute.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinute.Location = new System.Drawing.Point(6, 14);
            this.textBoxMinute.MaxLength = 3;
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(114, 79);
            this.textBoxMinute.TabIndex = 4;
            this.textBoxMinute.Text = "1";
            this.textBoxMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxPerso
            // 
            this.checkBoxPerso.AutoSize = true;
            this.checkBoxPerso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxPerso.Location = new System.Drawing.Point(45, 76);
            this.checkBoxPerso.Name = "checkBoxPerso";
            this.checkBoxPerso.Size = new System.Drawing.Size(68, 23);
            this.checkBoxPerso.TabIndex = 5;
            this.checkBoxPerso.Text = "Perso";
            this.checkBoxPerso.UseVisualStyleBackColor = true;
            this.checkBoxPerso.CheckedChanged += new System.EventHandler(this.checkBoxPerso_CheckedChanged);
            // 
            // checkBoxPreProg
            // 
            this.checkBoxPreProg.AutoSize = true;
            this.checkBoxPreProg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxPreProg.Location = new System.Drawing.Point(378, 76);
            this.checkBoxPreProg.Name = "checkBoxPreProg";
            this.checkBoxPreProg.Size = new System.Drawing.Size(154, 23);
            this.checkBoxPreProg.TabIndex = 6;
            this.checkBoxPreProg.Text = "Pré Programmer";
            this.checkBoxPreProg.UseVisualStyleBackColor = true;
            this.checkBoxPreProg.CheckedChanged += new System.EventHandler(this.checkBoxPreProg_CheckedChanged);
            // 
            // groupBoxPerso
            // 
            this.groupBoxPerso.Controls.Add(this.pictureBox1);
            this.groupBoxPerso.Controls.Add(this.pictureBox2);
            this.groupBoxPerso.Controls.Add(this.textBoxMinute);
            this.groupBoxPerso.Controls.Add(this.label2);
            this.groupBoxPerso.Enabled = false;
            this.groupBoxPerso.Location = new System.Drawing.Point(44, 94);
            this.groupBoxPerso.Name = "groupBoxPerso";
            this.groupBoxPerso.Size = new System.Drawing.Size(250, 100);
            this.groupBoxPerso.TabIndex = 6;
            this.groupBoxPerso.TabStop = false;
            // 
            // butValid
            // 
            this.butValid.FlatAppearance.BorderSize = 0;
            this.butValid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValid.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValid.ForeColor = System.Drawing.Color.Blue;
            this.butValid.Location = new System.Drawing.Point(45, 247);
            this.butValid.Name = "butValid";
            this.butValid.Size = new System.Drawing.Size(120, 54);
            this.butValid.TabIndex = 7;
            this.butValid.Text = "Valider";
            this.butValid.UseVisualStyleBackColor = true;
            this.butValid.Click += new System.EventHandler(this.butValid_Click);
            // 
            // butCancel
            // 
            this.butCancel.Enabled = false;
            this.butCancel.FlatAppearance.BorderSize = 0;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.Red;
            this.butCancel.Location = new System.Drawing.Point(165, 247);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(120, 54);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Annuler";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Visible = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // Minuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butValid);
            this.Controls.Add(this.checkBoxPreProg);
            this.Controls.Add(this.groupBoxPerso);
            this.Controls.Add(this.checkBoxPerso);
            this.Controls.Add(this.groupBoxPreProg);
            this.Controls.Add(this.label1);
            this.Name = "Minuteur";
            this.Size = new System.Drawing.Size(590, 340);
            this.Tag = "590";
            this.groupBoxPreProg.ResumeLayout(false);
            this.groupBoxPreProg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxPerso.ResumeLayout(false);
            this.groupBoxPerso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPreProg;
        private System.Windows.Forms.RadioButton radioBut45min;
        private System.Windows.Forms.RadioButton radioBut30min;
        private System.Windows.Forms.RadioButton radioBut15min;
        private System.Windows.Forms.RadioButton radioBut10min;
        private System.Windows.Forms.RadioButton radioBut5min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxPreProg;
        private System.Windows.Forms.CheckBox checkBoxPerso;
        private System.Windows.Forms.GroupBox groupBoxPerso;
        private System.Windows.Forms.Button butValid;
        private System.Windows.Forms.Button butCancel;
    }
}
