namespace TestInterfaceFraiche
{
    partial class NewCompte
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
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRue = new System.Windows.Forms.TextBox();
            this.radioButMale = new System.Windows.Forms.RadioButton();
            this.radioButMadame = new System.Windows.Forms.RadioButton();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butInscription = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumRue = new System.Windows.Forms.TextBox();
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(88, 92);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(129, 89);
            this.textBoxNom.MaxLength = 25;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(215, 20);
            this.textBoxNom.TabIndex = 3;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(439, 92);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 0;
            this.labelPrenom.Text = "Prénom :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(494, 89);
            this.textBoxPrenom.MaxLength = 25;
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(215, 20);
            this.textBoxPrenom.TabIndex = 4;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rue :";
            // 
            // textBoxRue
            // 
            this.textBoxRue.Location = new System.Drawing.Point(185, 273);
            this.textBoxRue.Name = "textBoxRue";
            this.textBoxRue.Size = new System.Drawing.Size(296, 20);
            this.textBoxRue.TabIndex = 9;
            this.textBoxRue.TextChanged += new System.EventHandler(this.textBoxRue_TextChanged);
            // 
            // radioButMale
            // 
            this.radioButMale.AutoSize = true;
            this.radioButMale.Location = new System.Drawing.Point(129, 66);
            this.radioButMale.Name = "radioButMale";
            this.radioButMale.Size = new System.Drawing.Size(68, 17);
            this.radioButMale.TabIndex = 1;
            this.radioButMale.TabStop = true;
            this.radioButMale.Text = "Monsieur";
            this.radioButMale.UseVisualStyleBackColor = true;
            // 
            // radioButMadame
            // 
            this.radioButMadame.AutoSize = true;
            this.radioButMadame.Location = new System.Drawing.Point(276, 66);
            this.radioButMadame.Name = "radioButMadame";
            this.radioButMadame.Size = new System.Drawing.Size(66, 17);
            this.radioButMadame.TabIndex = 2;
            this.radioButMadame.TabStop = true;
            this.radioButMadame.Text = "Madame";
            this.radioButMadame.UseVisualStyleBackColor = true;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(88, 133);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(32, 13);
            this.labelMail.TabIndex = 0;
            this.labelMail.Text = "Mail :";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(129, 130);
            this.textBoxMail.MaxLength = 40;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(215, 20);
            this.textBoxMail.TabIndex = 5;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de passe :";
            // 
            // textMDP
            // 
            this.textMDP.Location = new System.Drawing.Point(494, 130);
            this.textMDP.MaxLength = 15;
            this.textMDP.Name = "textMDP";
            this.textMDP.PasswordChar = '*';
            this.textMDP.Size = new System.Drawing.Size(215, 20);
            this.textMDP.TabIndex = 6;
            this.textMDP.TextChanged += new System.EventHandler(this.textMDP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Postal :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(92, 313);
            this.textBoxCodePostal.MaxLength = 5;
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(84, 20);
            this.textBoxCodePostal.TabIndex = 10;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ville :";
            // 
            // butInscription
            // 
            this.butInscription.BackColor = System.Drawing.Color.Green;
            this.butInscription.FlatAppearance.BorderSize = 0;
            this.butInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInscription.ForeColor = System.Drawing.Color.White;
            this.butInscription.Location = new System.Drawing.Point(519, 301);
            this.butInscription.Name = "butInscription";
            this.butInscription.Size = new System.Drawing.Size(190, 43);
            this.butInscription.TabIndex = 3;
            this.butInscription.Text = "S\'INSCRIRE";
            this.butInscription.UseVisualStyleBackColor = false;
            this.butInscription.Click += new System.EventHandler(this.butInscription_Click);
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Green;
            this.butCancel.FlatAppearance.BorderSize = 0;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(519, 246);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(190, 43);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "ANNULER";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de Naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rue :";
            // 
            // textBoxNumRue
            // 
            this.textBoxNumRue.Location = new System.Drawing.Point(91, 273);
            this.textBoxNumRue.Name = "textBoxNumRue";
            this.textBoxNumRue.Size = new System.Drawing.Size(49, 20);
            this.textBoxNumRue.TabIndex = 8;
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.Location = new System.Drawing.Point(127, 171);
            this.textBoxDateNaissance.MaxLength = 10;
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(101, 20);
            this.textBoxDateNaissance.TabIndex = 7;
            this.textBoxDateNaissance.TextChanged += new System.EventHandler(this.textBoxDateNaissance_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "(JJ/MM/AAAA)";
            // 
            // comboVille
            // 
            this.comboVille.DisplayMember = "NomVille";
            this.comboVille.FormattingEnabled = true;
            this.comboVille.Location = new System.Drawing.Point(234, 313);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(247, 21);
            this.comboVille.TabIndex = 11;
            this.comboVille.SelectionChangeCommitted += new System.EventHandler(this.comboVille_SelectionChangeCommitted);
            this.comboVille.SelectedValueChanged += new System.EventHandler(this.comboVille_SelectionChangeCommitted);
            // 
            // NewCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboVille);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butInscription);
            this.Controls.Add(this.radioButMadame);
            this.Controls.Add(this.radioButMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumRue);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMDP);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "NewCompte";
            this.Size = new System.Drawing.Size(817, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRue;
        private System.Windows.Forms.RadioButton radioButMale;
        private System.Windows.Forms.RadioButton radioButMadame;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butInscription;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumRue;
        private System.Windows.Forms.TextBox textBoxDateNaissance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboVille;
    }
}
