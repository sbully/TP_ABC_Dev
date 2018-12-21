namespace Exo_Menu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolphase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolphase2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesDeSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolphase3 = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.défilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolfenêtres = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriphase3 = new System.Windows.Forms.ToolStripSplitButton();
            this.Cassetool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripID = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ComboTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DefilementTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SyntheseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.Toolphase1,
            this.Toolphase2,
            this.Toolphase3,
            this.Toolfenêtres});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Toolphase3;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.fichierToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Toolphase1
            // 
            this.Toolphase1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem});
            this.Toolphase1.Enabled = false;
            this.Toolphase1.Name = "Toolphase1";
            this.Toolphase1.Size = new System.Drawing.Size(59, 20);
            this.Toolphase1.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.additionneurToolStripMenuItem_Click);
            // 
            // Toolphase2
            // 
            this.Toolphase2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrôlesDeSaisieToolStripMenuItem});
            this.Toolphase2.Enabled = false;
            this.Toolphase2.Name = "Toolphase2";
            this.Toolphase2.Size = new System.Drawing.Size(59, 20);
            this.Toolphase2.Text = "Phase 2";
            // 
            // contrôlesDeSaisieToolStripMenuItem
            // 
            this.contrôlesDeSaisieToolStripMenuItem.Name = "contrôlesDeSaisieToolStripMenuItem";
            this.contrôlesDeSaisieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contrôlesDeSaisieToolStripMenuItem.Text = "Contrôles de saisie";
            this.contrôlesDeSaisieToolStripMenuItem.Click += new System.EventHandler(this.contrôlesDeSaisieToolStripMenuItem_Click);
            // 
            // Toolphase3
            // 
            this.Toolphase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casesToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.défilementToolStripMenuItem,
            this.toolStripSeparator3,
            this.synthèseToolStripMenuItem});
            this.Toolphase3.Enabled = false;
            this.Toolphase3.Name = "Toolphase3";
            this.Toolphase3.Size = new System.Drawing.Size(59, 20);
            this.Toolphase3.Text = "Phase 3";
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // défilementToolStripMenuItem
            // 
            this.défilementToolStripMenuItem.Name = "défilementToolStripMenuItem";
            this.défilementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.défilementToolStripMenuItem.Text = "Défilement";
            this.défilementToolStripMenuItem.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            this.synthèseToolStripMenuItem.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // Toolfenêtres
            // 
            this.Toolfenêtres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.Toolfenêtres.Enabled = false;
            this.Toolfenêtres.Name = "Toolfenêtres";
            this.Toolfenêtres.Size = new System.Drawing.Size(63, 20);
            this.Toolfenêtres.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnect,
            this.toolStripSeparator1,
            this.toolStriphase3,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripConnect
            // 
            this.toolStripConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConnect.Image")));
            this.toolStripConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConnect.Name = "toolStripConnect";
            this.toolStripConnect.Size = new System.Drawing.Size(67, 22);
            this.toolStripConnect.Text = "S\'identifier";
            this.toolStripConnect.Click += new System.EventHandler(this.toolStripConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriphase3
            // 
            this.toolStriphase3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStriphase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cassetool,
            this.ComboTool,
            this.DefilementTool,
            this.SyntheseTool});
            this.toolStriphase3.Enabled = false;
            this.toolStriphase3.Image = ((System.Drawing.Image)(resources.GetObject("toolStriphase3.Image")));
            this.toolStriphase3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStriphase3.Name = "toolStriphase3";
            this.toolStriphase3.Size = new System.Drawing.Size(63, 22);
            this.toolStriphase3.Text = "Phase 3";
            this.toolStriphase3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Cassetool
            // 
            this.Cassetool.Name = "Cassetool";
            this.Cassetool.Size = new System.Drawing.Size(180, 22);
            this.Cassetool.Text = "Casse";
            this.Cassetool.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDate,
            this.toolStripID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDate
            // 
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(118, 17);
            this.toolStripDate.Text = "toolStripStatusLabel1";
            // 
            // toolStripID
            // 
            this.toolStripID.Name = "toolStripID";
            this.toolStripID.Size = new System.Drawing.Size(118, 17);
            this.toolStripID.Text = "toolStripStatusLabel2";
            // 
            // ComboTool
            // 
            this.ComboTool.Name = "ComboTool";
            this.ComboTool.Size = new System.Drawing.Size(180, 22);
            this.ComboTool.Text = "Combo";
            this.ComboTool.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // DefilementTool
            // 
            this.DefilementTool.Name = "DefilementTool";
            this.DefilementTool.Size = new System.Drawing.Size(180, 22);
            this.DefilementTool.Text = "Défilement";
            this.DefilementTool.Click += new System.EventHandler(this.défilementToolStripMenuItem_Click);
            // 
            // SyntheseTool
            // 
            this.SyntheseTool.Name = "SyntheseTool";
            this.SyntheseTool.Size = new System.Drawing.Size(180, 22);
            this.SyntheseTool.Text = "Synthèse";
            this.SyntheseTool.Click += new System.EventHandler(this.synthèseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Créer des formulaires";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Cassetool;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem défilementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionneurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrôlesDeSaisieToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripID;
        public System.Windows.Forms.ToolStripButton toolStripConnect;
        public System.Windows.Forms.ToolStripMenuItem Toolphase1;
        public System.Windows.Forms.ToolStripMenuItem Toolphase2;
        public System.Windows.Forms.ToolStripMenuItem Toolphase3;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem Toolfenêtres;
        private System.Windows.Forms.ToolStripMenuItem ComboTool;
        private System.Windows.Forms.ToolStripMenuItem DefilementTool;
        private System.Windows.Forms.ToolStripMenuItem SyntheseTool;
        public System.Windows.Forms.ToolStripSplitButton toolStriphase3;
    }
}

