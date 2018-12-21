namespace Exo_Menu
{
    partial class CtrlSaisie
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
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.Postal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(306, 298);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(122, 41);
            this.buttonEffacer.TabIndex = 6;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.Location = new System.Drawing.Point(306, 248);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(122, 41);
            this.ButtonValider.TabIndex = 5;
            this.ButtonValider.Text = "Valider";
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(118, 55);
            this.textBoxNom.MaxLength = 30;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(242, 20);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(118, 108);
            this.textBoxDate.MaxLength = 30;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(154, 20);
            this.textBoxDate.TabIndex = 2;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(118, 158);
            this.textBoxMontant.MaxLength = 30;
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(154, 20);
            this.textBoxMontant.TabIndex = 3;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Location = new System.Drawing.Point(118, 211);
            this.textBoxPostal.MaxLength = 5;
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(126, 20);
            this.textBoxPostal.TabIndex = 4;
            this.textBoxPostal.TextChanged += new System.EventHandler(this.textBoxPostal_TextChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(30, 58);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(30, 111);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(30, 161);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(52, 13);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant :";
            // 
            // Postal
            // 
            this.Postal.AutoSize = true;
            this.Postal.Location = new System.Drawing.Point(30, 214);
            this.Postal.Name = "Postal";
            this.Postal.Size = new System.Drawing.Size(64, 13);
            this.Postal.TabIndex = 2;
            this.Postal.Text = "Code Postal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(JJ/MM/AAAA)";
            // 
            // CtrlSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Postal);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.buttonEffacer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CtrlSaisie";
            this.Text = "Les contrôles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEffacer;
        public System.Windows.Forms.TextBox textBoxNom;
        public System.Windows.Forms.TextBox textBoxDate;
        public System.Windows.Forms.TextBox textBoxMontant;
        public System.Windows.Forms.TextBox textBoxPostal;
        public System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelMontant;
        public System.Windows.Forms.Label Postal;
        public System.Windows.Forms.Button ButtonValider;
        private System.Windows.Forms.Label label1;
    }
}

