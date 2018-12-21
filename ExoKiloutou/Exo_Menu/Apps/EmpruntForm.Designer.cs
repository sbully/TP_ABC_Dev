namespace Exo_Menu
{
    partial class EmpruntForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButTI9 = new System.Windows.Forms.RadioButton();
            this.radioButTI8 = new System.Windows.Forms.RadioButton();
            this.radioButTI7 = new System.Windows.Forms.RadioButton();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCapEmprunt = new System.Windows.Forms.Label();
            this.listBoxPeriod = new System.Windows.Forms.ListBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.ScrollMois = new System.Windows.Forms.HScrollBar();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelNbrMois = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNbrRembours = new System.Windows.Forms.Label();
            this.labelRembours = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(604, 22);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(133, 32);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(604, 76);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButTI9);
            this.groupBox1.Controls.Add(this.radioButTI8);
            this.groupBox1.Controls.Add(this.radioButTI7);
            this.groupBox1.Location = new System.Drawing.Point(381, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'intérêt";
            // 
            // radioButTI9
            // 
            this.radioButTI9.AutoSize = true;
            this.radioButTI9.Location = new System.Drawing.Point(33, 120);
            this.radioButTI9.Name = "radioButTI9";
            this.radioButTI9.Size = new System.Drawing.Size(42, 17);
            this.radioButTI9.TabIndex = 5;
            this.radioButTI9.Tag = "0.09";
            this.radioButTI9.Text = "9 %";
            this.radioButTI9.UseVisualStyleBackColor = true;
            this.radioButTI9.CheckedChanged += new System.EventHandler(this.radioButTI9_CheckedChanged);
            // 
            // radioButTI8
            // 
            this.radioButTI8.AutoSize = true;
            this.radioButTI8.Location = new System.Drawing.Point(33, 80);
            this.radioButTI8.Name = "radioButTI8";
            this.radioButTI8.Size = new System.Drawing.Size(42, 17);
            this.radioButTI8.TabIndex = 4;
            this.radioButTI8.Tag = "0.08";
            this.radioButTI8.Text = "8 %";
            this.radioButTI8.UseVisualStyleBackColor = true;
            this.radioButTI8.CheckedChanged += new System.EventHandler(this.radioButTI8_CheckedChanged);
            // 
            // radioButTI7
            // 
            this.radioButTI7.AutoSize = true;
            this.radioButTI7.Checked = true;
            this.radioButTI7.Location = new System.Drawing.Point(33, 40);
            this.radioButTI7.Name = "radioButTI7";
            this.radioButTI7.Size = new System.Drawing.Size(42, 17);
            this.radioButTI7.TabIndex = 3;
            this.radioButTI7.TabStop = true;
            this.radioButTI7.Tag = "0.07";
            this.radioButTI7.Text = "7 %";
            this.radioButTI7.UseVisualStyleBackColor = true;
            this.radioButTI7.CheckedChanged += new System.EventHandler(this.radioButTI7_CheckedChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(108, 22);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(210, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(108, 76);
            this.textBoxMontant.MaxLength = 10;
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(210, 20);
            this.textBoxMontant.TabIndex = 1;
            this.textBoxMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 25);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // labelCapEmprunt
            // 
            this.labelCapEmprunt.AutoSize = true;
            this.labelCapEmprunt.Location = new System.Drawing.Point(12, 79);
            this.labelCapEmprunt.Name = "labelCapEmprunt";
            this.labelCapEmprunt.Size = new System.Drawing.Size(87, 13);
            this.labelCapEmprunt.TabIndex = 4;
            this.labelCapEmprunt.Text = "Capital Emprunté";
            // 
            // listBoxPeriod
            // 
            this.listBoxPeriod.FormattingEnabled = true;
            this.listBoxPeriod.Location = new System.Drawing.Point(36, 245);
            this.listBoxPeriod.Name = "listBoxPeriod";
            this.listBoxPeriod.Size = new System.Drawing.Size(281, 69);
            this.listBoxPeriod.TabIndex = 5;
            this.listBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriod_SelectedIndexChanged);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(33, 229);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(146, 13);
            this.labelPeriod.TabIndex = 6;
            this.labelPeriod.Text = "Périodicité de remboursement";
            // 
            // ScrollMois
            // 
            this.ScrollMois.Location = new System.Drawing.Point(183, 142);
            this.ScrollMois.Maximum = 249;
            this.ScrollMois.Minimum = 1;
            this.ScrollMois.Name = "ScrollMois";
            this.ScrollMois.Size = new System.Drawing.Size(166, 30);
            this.ScrollMois.TabIndex = 7;
            this.ScrollMois.Value = 1;
            this.ScrollMois.ValueChanged += new System.EventHandler(this.ScrollMois_ValueChanged);
            // 
            // labelDuree
            // 
            this.labelDuree.Location = new System.Drawing.Point(12, 144);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(109, 30);
            this.labelDuree.TabIndex = 8;
            this.labelDuree.Text = "Durée en mois du remboursement";
            // 
            // labelNbrMois
            // 
            this.labelNbrMois.AutoSize = true;
            this.labelNbrMois.Location = new System.Drawing.Point(127, 146);
            this.labelNbrMois.Name = "labelNbrMois";
            this.labelNbrMois.Size = new System.Drawing.Size(35, 13);
            this.labelNbrMois.TabIndex = 9;
            this.labelNbrMois.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remboursements";
            // 
            // labelNbrRembours
            // 
            this.labelNbrRembours.AutoSize = true;
            this.labelNbrRembours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrRembours.ForeColor = System.Drawing.Color.Red;
            this.labelNbrRembours.Location = new System.Drawing.Point(427, 229);
            this.labelNbrRembours.Name = "labelNbrRembours";
            this.labelNbrRembours.Size = new System.Drawing.Size(57, 20);
            this.labelNbrRembours.TabIndex = 11;
            this.labelNbrRembours.Text = "label2";
            // 
            // labelRembours
            // 
            this.labelRembours.AutoSize = true;
            this.labelRembours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRembours.ForeColor = System.Drawing.Color.Red;
            this.labelRembours.Location = new System.Drawing.Point(558, 294);
            this.labelRembours.Name = "labelRembours";
            this.labelRembours.Size = new System.Drawing.Size(51, 20);
            this.labelRembours.TabIndex = 12;
            this.labelRembours.Text = "label3";
            // 
            // EmpruntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 346);
            this.Controls.Add(this.labelRembours);
            this.Controls.Add(this.labelNbrRembours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNbrMois);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.ScrollMois);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.listBoxPeriod);
            this.Controls.Add(this.labelCapEmprunt);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmpruntForm";
            this.Text = "Emprunts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButTI9;
        private System.Windows.Forms.RadioButton radioButTI8;
        private System.Windows.Forms.RadioButton radioButTI7;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCapEmprunt;
        private System.Windows.Forms.ListBox listBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.HScrollBar ScrollMois;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.Label labelNbrMois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNbrRembours;
        private System.Windows.Forms.Label labelRembours;
    }
}

