namespace Recherche_Ville_chargement_CSV
{
    partial class Demarrage
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
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadCsv = new System.Windows.Forms.Button();
            this.buttonWriteCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DisplayMember = "NomVille";
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(279, 39);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(235, 21);
            this.comboBoxVille.TabIndex = 1;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(104, 39);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodePostal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code postal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ville :";
            // 
            // buttonLoadCsv
            // 
            this.buttonLoadCsv.Location = new System.Drawing.Point(38, 135);
            this.buttonLoadCsv.Name = "buttonLoadCsv";
            this.buttonLoadCsv.Size = new System.Drawing.Size(139, 28);
            this.buttonLoadCsv.TabIndex = 3;
            this.buttonLoadCsv.Text = "Charger";
            this.buttonLoadCsv.UseVisualStyleBackColor = true;
            this.buttonLoadCsv.Click += new System.EventHandler(this.buttonLoadCsv_Click);
            // 
            // buttonWriteCsv
            // 
            this.buttonWriteCsv.Location = new System.Drawing.Point(375, 135);
            this.buttonWriteCsv.Name = "buttonWriteCsv";
            this.buttonWriteCsv.Size = new System.Drawing.Size(139, 28);
            this.buttonWriteCsv.TabIndex = 3;
            this.buttonWriteCsv.Text = "Ecrire";
            this.buttonWriteCsv.UseVisualStyleBackColor = true;
            this.buttonWriteCsv.Click += new System.EventHandler(this.buttonWriteCsv_Click);
            // 
            // Demarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 175);
            this.Controls.Add(this.buttonWriteCsv);
            this.Controls.Add(this.buttonLoadCsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.comboBoxVille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Demarrage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadCsv;
        private System.Windows.Forms.Button buttonWriteCsv;
    }
}

