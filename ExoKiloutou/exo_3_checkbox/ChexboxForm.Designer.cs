namespace exo_3_checkbox
{
    partial class ChexboxForm
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
            this.labelTextSaisie = new System.Windows.Forms.Label();
            this.textSaisi = new System.Windows.Forms.TextBox();
            this.groupChoix = new System.Windows.Forms.GroupBox();
            this.checkCasse = new System.Windows.Forms.CheckBox();
            this.checkFontColor = new System.Windows.Forms.CheckBox();
            this.ChekBackColor = new System.Windows.Forms.CheckBox();
            this.groupFond = new System.Windows.Forms.GroupBox();
            this.BackBlue = new System.Windows.Forms.RadioButton();
            this.BackGreen = new System.Windows.Forms.RadioButton();
            this.BackRed = new System.Windows.Forms.RadioButton();
            this.groupCaract = new System.Windows.Forms.GroupBox();
            this.FrondBlack = new System.Windows.Forms.RadioButton();
            this.FrontRed = new System.Windows.Forms.RadioButton();
            this.FrontWhite = new System.Windows.Forms.RadioButton();
            this.groupCasse = new System.Windows.Forms.GroupBox();
            this.CasseMinu = new System.Windows.Forms.RadioButton();
            this.Majuscules = new System.Windows.Forms.RadioButton();
            this.labeltxtmodif = new System.Windows.Forms.Label();
            this.groupChoix.SuspendLayout();
            this.groupFond.SuspendLayout();
            this.groupCaract.SuspendLayout();
            this.groupCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTextSaisie
            // 
            this.labelTextSaisie.AutoSize = true;
            this.labelTextSaisie.Location = new System.Drawing.Point(31, 20);
            this.labelTextSaisie.Name = "labelTextSaisie";
            this.labelTextSaisie.Size = new System.Drawing.Size(90, 13);
            this.labelTextSaisie.TabIndex = 0;
            this.labelTextSaisie.Text = "Tapez votre texte";
            // 
            // textSaisi
            // 
            this.textSaisi.Location = new System.Drawing.Point(31, 43);
            this.textSaisi.Name = "textSaisi";
            this.textSaisi.Size = new System.Drawing.Size(303, 20);
            this.textSaisi.TabIndex = 0;
            this.textSaisi.TextChanged += new System.EventHandler(this.textSaisi_TextChanged);
            // 
            // groupChoix
            // 
            this.groupChoix.Controls.Add(this.checkCasse);
            this.groupChoix.Controls.Add(this.checkFontColor);
            this.groupChoix.Controls.Add(this.ChekBackColor);
            this.groupChoix.Enabled = false;
            this.groupChoix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupChoix.Location = new System.Drawing.Point(363, 20);
            this.groupChoix.Name = "groupChoix";
            this.groupChoix.Size = new System.Drawing.Size(156, 89);
            this.groupChoix.TabIndex = 2;
            this.groupChoix.TabStop = false;
            this.groupChoix.Text = "Choix";
            // 
            // checkCasse
            // 
            this.checkCasse.AutoSize = true;
            this.checkCasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkCasse.Location = new System.Drawing.Point(16, 66);
            this.checkCasse.Name = "checkCasse";
            this.checkCasse.Size = new System.Drawing.Size(55, 17);
            this.checkCasse.TabIndex = 0;
            this.checkCasse.Text = "Casse";
            this.checkCasse.UseVisualStyleBackColor = true;
            this.checkCasse.CheckedChanged += new System.EventHandler(this.checkCasse_CheckedChanged);
            // 
            // checkFontColor
            // 
            this.checkFontColor.AutoSize = true;
            this.checkFontColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkFontColor.Location = new System.Drawing.Point(16, 43);
            this.checkFontColor.Name = "checkFontColor";
            this.checkFontColor.Size = new System.Drawing.Size(135, 17);
            this.checkFontColor.TabIndex = 0;
            this.checkFontColor.Text = "Couleur des caractères";
            this.checkFontColor.UseVisualStyleBackColor = true;
            this.checkFontColor.CheckedChanged += new System.EventHandler(this.checkFontColor_CheckedChanged);
            // 
            // ChekBackColor
            // 
            this.ChekBackColor.AutoSize = true;
            this.ChekBackColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChekBackColor.Location = new System.Drawing.Point(16, 20);
            this.ChekBackColor.Name = "ChekBackColor";
            this.ChekBackColor.Size = new System.Drawing.Size(101, 17);
            this.ChekBackColor.TabIndex = 0;
            this.ChekBackColor.Text = "Couleur du fond";
            this.ChekBackColor.UseVisualStyleBackColor = true;
            this.ChekBackColor.CheckedChanged += new System.EventHandler(this.ChekBackColor_CheckedChanged);
            // 
            // groupFond
            // 
            this.groupFond.Controls.Add(this.BackBlue);
            this.groupFond.Controls.Add(this.BackGreen);
            this.groupFond.Controls.Add(this.BackRed);
            this.groupFond.Enabled = false;
            this.groupFond.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupFond.Location = new System.Drawing.Point(31, 156);
            this.groupFond.Name = "groupFond";
            this.groupFond.Size = new System.Drawing.Size(72, 89);
            this.groupFond.TabIndex = 2;
            this.groupFond.TabStop = false;
            this.groupFond.Text = "Fond";
            // 
            // BackBlue
            // 
            this.BackBlue.AutoSize = true;
            this.BackBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackBlue.Location = new System.Drawing.Point(6, 65);
            this.BackBlue.Name = "BackBlue";
            this.BackBlue.Size = new System.Drawing.Size(46, 17);
            this.BackBlue.TabIndex = 0;
            this.BackBlue.TabStop = true;
            this.BackBlue.Tag = "Blue";
            this.BackBlue.Text = "Bleu";
            this.BackBlue.UseVisualStyleBackColor = true;
            this.BackBlue.CheckedChanged += new System.EventHandler(this.BackBlue_CheckedChanged);
            // 
            // BackGreen
            // 
            this.BackGreen.AutoSize = true;
            this.BackGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackGreen.Location = new System.Drawing.Point(6, 42);
            this.BackGreen.Name = "BackGreen";
            this.BackGreen.Size = new System.Drawing.Size(44, 17);
            this.BackGreen.TabIndex = 0;
            this.BackGreen.TabStop = true;
            this.BackGreen.Tag = "Green";
            this.BackGreen.Text = "Vert";
            this.BackGreen.UseVisualStyleBackColor = true;
            this.BackGreen.CheckedChanged += new System.EventHandler(this.BackGreen_CheckedChanged);
            // 
            // BackRed
            // 
            this.BackRed.AutoSize = true;
            this.BackRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackRed.Location = new System.Drawing.Point(6, 19);
            this.BackRed.Name = "BackRed";
            this.BackRed.Size = new System.Drawing.Size(57, 17);
            this.BackRed.TabIndex = 0;
            this.BackRed.TabStop = true;
            this.BackRed.Tag = "Red";
            this.BackRed.Text = "Rouge";
            this.BackRed.UseVisualStyleBackColor = true;
            this.BackRed.CheckedChanged += new System.EventHandler(this.BackRed_CheckedChanged);
            // 
            // groupCaract
            // 
            this.groupCaract.Controls.Add(this.FrondBlack);
            this.groupCaract.Controls.Add(this.FrontRed);
            this.groupCaract.Controls.Add(this.FrontWhite);
            this.groupCaract.Enabled = false;
            this.groupCaract.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupCaract.Location = new System.Drawing.Point(136, 156);
            this.groupCaract.Name = "groupCaract";
            this.groupCaract.Size = new System.Drawing.Size(74, 89);
            this.groupCaract.TabIndex = 2;
            this.groupCaract.TabStop = false;
            this.groupCaract.Text = "Caractères";
            // 
            // FrondBlack
            // 
            this.FrondBlack.AutoSize = true;
            this.FrondBlack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrondBlack.Location = new System.Drawing.Point(6, 65);
            this.FrondBlack.Name = "FrondBlack";
            this.FrondBlack.Size = new System.Drawing.Size(44, 17);
            this.FrondBlack.TabIndex = 0;
            this.FrondBlack.TabStop = true;
            this.FrondBlack.Tag = "Black";
            this.FrondBlack.Text = "Noir";
            this.FrondBlack.UseVisualStyleBackColor = true;
            this.FrondBlack.CheckedChanged += new System.EventHandler(this.FrondBlack_CheckedChanged);
            // 
            // FrontRed
            // 
            this.FrontRed.AutoSize = true;
            this.FrontRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrontRed.Location = new System.Drawing.Point(6, 19);
            this.FrontRed.Name = "FrontRed";
            this.FrontRed.Size = new System.Drawing.Size(57, 17);
            this.FrontRed.TabIndex = 0;
            this.FrontRed.TabStop = true;
            this.FrontRed.Tag = "Red";
            this.FrontRed.Text = "Rouge";
            this.FrontRed.UseVisualStyleBackColor = true;
            this.FrontRed.CheckedChanged += new System.EventHandler(this.FrontRed_CheckedChanged);
            // 
            // FrontWhite
            // 
            this.FrontWhite.AutoSize = true;
            this.FrontWhite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FrontWhite.Location = new System.Drawing.Point(6, 42);
            this.FrontWhite.Name = "FrontWhite";
            this.FrontWhite.Size = new System.Drawing.Size(52, 17);
            this.FrontWhite.TabIndex = 0;
            this.FrontWhite.TabStop = true;
            this.FrontWhite.Tag = "White";
            this.FrontWhite.Text = "Blanc";
            this.FrontWhite.UseVisualStyleBackColor = true;
            this.FrontWhite.CheckedChanged += new System.EventHandler(this.FrontWhite_CheckedChanged);
            // 
            // groupCasse
            // 
            this.groupCasse.Controls.Add(this.CasseMinu);
            this.groupCasse.Controls.Add(this.Majuscules);
            this.groupCasse.Enabled = false;
            this.groupCasse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupCasse.Location = new System.Drawing.Point(236, 177);
            this.groupCasse.Name = "groupCasse";
            this.groupCasse.Size = new System.Drawing.Size(98, 68);
            this.groupCasse.TabIndex = 2;
            this.groupCasse.TabStop = false;
            this.groupCasse.Text = "Casse";
            // 
            // CasseMinu
            // 
            this.CasseMinu.AutoSize = true;
            this.CasseMinu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CasseMinu.Location = new System.Drawing.Point(7, 21);
            this.CasseMinu.Name = "CasseMinu";
            this.CasseMinu.Size = new System.Drawing.Size(78, 17);
            this.CasseMinu.TabIndex = 0;
            this.CasseMinu.TabStop = true;
            this.CasseMinu.Text = "Minuscules";
            this.CasseMinu.UseVisualStyleBackColor = true;
            this.CasseMinu.CheckedChanged += new System.EventHandler(this.CasseMinu_CheckedChanged);
            // 
            // Majuscules
            // 
            this.Majuscules.AutoSize = true;
            this.Majuscules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Majuscules.Location = new System.Drawing.Point(7, 44);
            this.Majuscules.Name = "Majuscules";
            this.Majuscules.Size = new System.Drawing.Size(78, 17);
            this.Majuscules.TabIndex = 0;
            this.Majuscules.TabStop = true;
            this.Majuscules.Text = "Majuscules";
            this.Majuscules.UseVisualStyleBackColor = true;
            this.Majuscules.CheckedChanged += new System.EventHandler(this.Majuscules_CheckedChanged);
            // 
            // labeltxtmodif
            // 
            this.labeltxtmodif.AutoSize = true;
            this.labeltxtmodif.Location = new System.Drawing.Point(28, 96);
            this.labeltxtmodif.Name = "labeltxtmodif";
            this.labeltxtmodif.Size = new System.Drawing.Size(35, 13);
            this.labeltxtmodif.TabIndex = 3;
            this.labeltxtmodif.Tag = "label1";
            this.labeltxtmodif.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 258);
            this.Controls.Add(this.labeltxtmodif);
            this.Controls.Add(this.groupCasse);
            this.Controls.Add(this.groupCaract);
            this.Controls.Add(this.groupFond);
            this.Controls.Add(this.groupChoix);
            this.Controls.Add(this.textSaisi);
            this.Controls.Add(this.labelTextSaisie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CheckBox et RadioButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupChoix.ResumeLayout(false);
            this.groupChoix.PerformLayout();
            this.groupFond.ResumeLayout(false);
            this.groupFond.PerformLayout();
            this.groupCaract.ResumeLayout(false);
            this.groupCaract.PerformLayout();
            this.groupCasse.ResumeLayout(false);
            this.groupCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextSaisie;
        private System.Windows.Forms.TextBox textSaisi;
        private System.Windows.Forms.GroupBox groupChoix;
        private System.Windows.Forms.CheckBox checkCasse;
        private System.Windows.Forms.CheckBox checkFontColor;
        private System.Windows.Forms.CheckBox ChekBackColor;
        private System.Windows.Forms.GroupBox groupFond;
        private System.Windows.Forms.RadioButton BackRed;
        private System.Windows.Forms.GroupBox groupCaract;
        private System.Windows.Forms.GroupBox groupCasse;
        private System.Windows.Forms.RadioButton BackBlue;
        private System.Windows.Forms.RadioButton BackGreen;
        private System.Windows.Forms.RadioButton FrondBlack;
        private System.Windows.Forms.RadioButton FrontRed;
        private System.Windows.Forms.RadioButton FrontWhite;
        private System.Windows.Forms.RadioButton CasseMinu;
        private System.Windows.Forms.RadioButton Majuscules;
        private System.Windows.Forms.Label labeltxtmodif;
    }
}

