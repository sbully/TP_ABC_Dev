namespace Exo_Menu
{
    partial class ListcomboForm
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
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonAddSimple = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemoveSimple = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxList
            // 
            this.comboBoxList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(12, 51);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(143, 21);
            this.comboBoxList.TabIndex = 0;
            this.comboBoxList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxList_KeyPress);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(54, 24);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(60, 20);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 238);
            this.listBox1.TabIndex = 2;
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCible.Location = new System.Drawing.Point(361, 24);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(44, 20);
            this.labelCible.TabIndex = 3;
            this.labelCible.Text = "Cible";
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(315, 315);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(48, 23);
            this.buttonTop.TabIndex = 4;
            this.buttonTop.Text = "Haut";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(398, 315);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(48, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Bas";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonAddSimple
            // 
            this.buttonAddSimple.Location = new System.Drawing.Point(178, 51);
            this.buttonAddSimple.Name = "buttonAddSimple";
            this.buttonAddSimple.Size = new System.Drawing.Size(73, 30);
            this.buttonAddSimple.TabIndex = 5;
            this.buttonAddSimple.Text = ">";
            this.buttonAddSimple.UseVisualStyleBackColor = true;
            this.buttonAddSimple.Click += new System.EventHandler(this.buttonAddSimple_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(178, 87);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(73, 30);
            this.buttonAddAll.TabIndex = 5;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonRemoveSimple
            // 
            this.buttonRemoveSimple.Location = new System.Drawing.Point(178, 186);
            this.buttonRemoveSimple.Name = "buttonRemoveSimple";
            this.buttonRemoveSimple.Size = new System.Drawing.Size(73, 30);
            this.buttonRemoveSimple.TabIndex = 5;
            this.buttonRemoveSimple.Text = "<";
            this.buttonRemoveSimple.UseVisualStyleBackColor = true;
            this.buttonRemoveSimple.Click += new System.EventHandler(this.buttonRemoveSimple_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(178, 222);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(73, 30);
            this.buttonRemoveAll.TabIndex = 5;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 362);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonRemoveSimple);
            this.Controls.Add(this.buttonAddSimple);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBoxList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelCible;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonAddSimple;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemoveSimple;
        private System.Windows.Forms.Button buttonRemoveAll;
        public System.Windows.Forms.ListBox listBox1;
    }
}

