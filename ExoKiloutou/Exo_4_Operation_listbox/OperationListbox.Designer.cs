namespace Exo_4_Operation_listbox
{
    partial class OperationListbox
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
            this.listboxElem = new System.Windows.Forms.ListBox();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.labelNewElem = new System.Windows.Forms.Label();
            this.buttonViderList = new System.Windows.Forms.Button();
            this.buttonSelectList = new System.Windows.Forms.Button();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelProperty = new System.Windows.Forms.Label();
            this.labelItemCount = new System.Windows.Forms.Label();
            this.labelSlectIndex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxItemCountRO = new System.Windows.Forms.TextBox();
            this.textBoxIndexRO = new System.Windows.Forms.TextBox();
            this.textBoxNomRO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listboxElem
            // 
            this.listboxElem.FormattingEnabled = true;
            this.listboxElem.Location = new System.Drawing.Point(12, 167);
            this.listboxElem.Name = "listboxElem";
            this.listboxElem.Size = new System.Drawing.Size(119, 121);
            this.listboxElem.TabIndex = 5;
            this.listboxElem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listboxElem_MouseClick);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(12, 79);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(143, 30);
            this.buttonAddList.TabIndex = 1;
            this.buttonAddList.Text = "Ajout Liste";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(12, 38);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(143, 20);
            this.NomTextBox.TabIndex = 0;
            // 
            // labelNewElem
            // 
            this.labelNewElem.AutoSize = true;
            this.labelNewElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewElem.Location = new System.Drawing.Point(12, 9);
            this.labelNewElem.Name = "labelNewElem";
            this.labelNewElem.Size = new System.Drawing.Size(96, 13);
            this.labelNewElem.TabIndex = 3;
            this.labelNewElem.Text = "Nouvel Elément";
            // 
            // buttonViderList
            // 
            this.buttonViderList.Location = new System.Drawing.Point(277, 79);
            this.buttonViderList.Name = "buttonViderList";
            this.buttonViderList.Size = new System.Drawing.Size(143, 30);
            this.buttonViderList.TabIndex = 4;
            this.buttonViderList.Text = "Vider la Liste";
            this.buttonViderList.UseVisualStyleBackColor = true;
            this.buttonViderList.Click += new System.EventHandler(this.buttonViderList_Click);
            // 
            // buttonSelectList
            // 
            this.buttonSelectList.Location = new System.Drawing.Point(277, 38);
            this.buttonSelectList.Name = "buttonSelectList";
            this.buttonSelectList.Size = new System.Drawing.Size(143, 30);
            this.buttonSelectList.TabIndex = 3;
            this.buttonSelectList.Text = "Sélectionner";
            this.buttonSelectList.UseVisualStyleBackColor = true;
            this.buttonSelectList.Click += new System.EventHandler(this.buttonSelectList_Click);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(203, 9);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(87, 13);
            this.labelIndex.TabIndex = 4;
            this.labelIndex.Text = "Index Elément";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(206, 38);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(50, 20);
            this.textBoxIndex.TabIndex = 2;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(12, 139);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(51, 13);
            this.labelList.TabIndex = 6;
            this.labelList.Text = "LstListe";
            // 
            // labelProperty
            // 
            this.labelProperty.AutoSize = true;
            this.labelProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProperty.Location = new System.Drawing.Point(203, 139);
            this.labelProperty.Name = "labelProperty";
            this.labelProperty.Size = new System.Drawing.Size(64, 13);
            this.labelProperty.TabIndex = 6;
            this.labelProperty.Text = "Propriétés";
            // 
            // labelItemCount
            // 
            this.labelItemCount.AutoSize = true;
            this.labelItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemCount.Location = new System.Drawing.Point(203, 167);
            this.labelItemCount.Name = "labelItemCount";
            this.labelItemCount.Size = new System.Drawing.Size(63, 13);
            this.labelItemCount.TabIndex = 6;
            this.labelItemCount.Text = "Items.Count";
            // 
            // labelSlectIndex
            // 
            this.labelSlectIndex.AutoSize = true;
            this.labelSlectIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlectIndex.Location = new System.Drawing.Point(203, 194);
            this.labelSlectIndex.Name = "labelSlectIndex";
            this.labelSlectIndex.Size = new System.Drawing.Size(78, 13);
            this.labelSlectIndex.TabIndex = 6;
            this.labelSlectIndex.Text = "Selected Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text";
            // 
            // textBoxItemCountRO
            // 
            this.textBoxItemCountRO.Location = new System.Drawing.Point(287, 164);
            this.textBoxItemCountRO.Name = "textBoxItemCountRO";
            this.textBoxItemCountRO.ReadOnly = true;
            this.textBoxItemCountRO.Size = new System.Drawing.Size(32, 20);
            this.textBoxItemCountRO.TabIndex = 7;
            // 
            // textBoxIndexRO
            // 
            this.textBoxIndexRO.Location = new System.Drawing.Point(287, 191);
            this.textBoxIndexRO.Name = "textBoxIndexRO";
            this.textBoxIndexRO.ReadOnly = true;
            this.textBoxIndexRO.Size = new System.Drawing.Size(32, 20);
            this.textBoxIndexRO.TabIndex = 7;
            // 
            // textBoxNomRO
            // 
            this.textBoxNomRO.Location = new System.Drawing.Point(287, 219);
            this.textBoxNomRO.Name = "textBoxNomRO";
            this.textBoxNomRO.ReadOnly = true;
            this.textBoxNomRO.Size = new System.Drawing.Size(122, 20);
            this.textBoxNomRO.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 300);
            this.Controls.Add(this.textBoxNomRO);
            this.Controls.Add(this.textBoxIndexRO);
            this.Controls.Add(this.textBoxItemCountRO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSlectIndex);
            this.Controls.Add(this.labelItemCount);
            this.Controls.Add(this.labelProperty);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelNewElem);
            this.Controls.Add(this.NomTextBox);
            this.Controls.Add(this.buttonSelectList);
            this.Controls.Add(this.buttonViderList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.listboxElem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Les listes et leurs propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxElem;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label labelNewElem;
        private System.Windows.Forms.Button buttonViderList;
        private System.Windows.Forms.Button buttonSelectList;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelProperty;
        private System.Windows.Forms.Label labelItemCount;
        private System.Windows.Forms.Label labelSlectIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxItemCountRO;
        private System.Windows.Forms.TextBox textBoxIndexRO;
        private System.Windows.Forms.TextBox textBoxNomRO;
    }
}

