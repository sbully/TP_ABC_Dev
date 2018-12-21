namespace Exo_Menu
{
    partial class CompoCouleur
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.labelBleu = new System.Windows.Forms.Label();
            this.ScrollRed = new System.Windows.Forms.HScrollBar();
            this.ScrollGreen = new System.Windows.Forms.HScrollBar();
            this.ScrollBlue = new System.Windows.Forms.HScrollBar();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelFinalColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(79, 78);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(351, 23);
            this.hScrollBar1.TabIndex = 0;
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(12, 83);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(39, 13);
            this.labelRouge.TabIndex = 1;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(12, 128);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(26, 13);
            this.labelVert.TabIndex = 1;
            this.labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(12, 178);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(28, 13);
            this.labelBleu.TabIndex = 1;
            this.labelBleu.Text = "Bleu";
            // 
            // ScrollRed
            // 
            this.ScrollRed.Location = new System.Drawing.Point(79, 78);
            this.ScrollRed.Maximum = 264;
            this.ScrollRed.Name = "ScrollRed";
            this.ScrollRed.Size = new System.Drawing.Size(351, 23);
            this.ScrollRed.TabIndex = 0;
            this.ScrollRed.ValueChanged += new System.EventHandler(this.ScrollRed_ValueChanged);
            // 
            // ScrollGreen
            // 
            this.ScrollGreen.Location = new System.Drawing.Point(79, 123);
            this.ScrollGreen.Maximum = 264;
            this.ScrollGreen.Name = "ScrollGreen";
            this.ScrollGreen.Size = new System.Drawing.Size(351, 23);
            this.ScrollGreen.TabIndex = 0;
            this.ScrollGreen.ValueChanged += new System.EventHandler(this.ScrollGreen_ValueChanged);
            // 
            // ScrollBlue
            // 
            this.ScrollBlue.Location = new System.Drawing.Point(79, 173);
            this.ScrollBlue.Maximum = 264;
            this.ScrollBlue.Name = "ScrollBlue";
            this.ScrollBlue.Size = new System.Drawing.Size(351, 23);
            this.ScrollBlue.TabIndex = 0;
            this.ScrollBlue.ValueChanged += new System.EventHandler(this.ScrollBlue_ValueChanged);
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(458, 81);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(49, 20);
            this.numRed.TabIndex = 3;
            this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(458, 126);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(49, 20);
            this.numGreen.TabIndex = 3;
            this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(458, 176);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(49, 20);
            this.numBlue.TabIndex = 3;
            this.numBlue.ValueChanged += new System.EventHandler(this.numBlue_ValueChanged);
            // 
            // labelRed
            // 
            this.labelRed.Location = new System.Drawing.Point(513, 78);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(72, 23);
            this.labelRed.TabIndex = 4;
            // 
            // labelGreen
            // 
            this.labelGreen.Location = new System.Drawing.Point(513, 123);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(72, 23);
            this.labelGreen.TabIndex = 4;
            // 
            // labelBlue
            // 
            this.labelBlue.Location = new System.Drawing.Point(513, 173);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(72, 23);
            this.labelBlue.TabIndex = 4;
            // 
            // labelFinalColor
            // 
            this.labelFinalColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalColor.Location = new System.Drawing.Point(15, 215);
            this.labelFinalColor.Name = "labelFinalColor";
            this.labelFinalColor.Size = new System.Drawing.Size(570, 83);
            this.labelFinalColor.TabIndex = 5;
            this.labelFinalColor.Text = "label1";
            this.labelFinalColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompoCouleur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 309);
            this.Controls.Add(this.labelFinalColor);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.numBlue);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.ScrollBlue);
            this.Controls.Add(this.ScrollGreen);
            this.Controls.Add(this.ScrollRed);
            this.Controls.Add(this.labelRouge);
            this.Controls.Add(this.hScrollBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompoCouleur";
            this.Text = "Défilement";
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label labelRouge;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.Label labelBleu;
        private System.Windows.Forms.HScrollBar ScrollRed;
        private System.Windows.Forms.HScrollBar ScrollGreen;
        private System.Windows.Forms.HScrollBar ScrollBlue;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.NumericUpDown numBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelFinalColor;
    }
}

