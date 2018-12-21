namespace Minuteur
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeCalendar = new System.Windows.Forms.DateTimePicker();
            this.textAlarme = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEntrerText = new System.Windows.Forms.Label();
            this.HeureUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelJour = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.MinuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupAlarme = new System.Windows.Forms.GroupBox();
            this.radioShutdown = new System.Windows.Forms.RadioButton();
            this.radioTextAlarm = new System.Windows.Forms.RadioButton();
            this.groupMinuteur = new System.Windows.Forms.GroupBox();
            this.radio12heure = new System.Windows.Forms.RadioButton();
            this.radio4heure = new System.Windows.Forms.RadioButton();
            this.radioheure = new System.Windows.Forms.RadioButton();
            this.radio6heure = new System.Windows.Forms.RadioButton();
            this.radio2heure = new System.Windows.Forms.RadioButton();
            this.radiodemiheure = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MinuteurCheck = new System.Windows.Forms.RadioButton();
            this.AlarmeCheck = new System.Windows.Forms.RadioButton();
            this.groupTypeMin = new System.Windows.Forms.GroupBox();
            this.radioRepeat = new System.Windows.Forms.RadioButton();
            this.radio1fois = new System.Windows.Forms.RadioButton();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.LabelAlarmText = new System.Windows.Forms.Label();
            this.labelAlarmDate = new System.Windows.Forms.Label();
            this.labelAlarmHeure = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).BeginInit();
            this.groupAlarme.SuspendLayout();
            this.groupMinuteur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupTypeMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // dateTimeCalendar
            // 
            this.dateTimeCalendar.Location = new System.Drawing.Point(106, 13);
            this.dateTimeCalendar.Name = "dateTimeCalendar";
            this.dateTimeCalendar.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCalendar.TabIndex = 1;
            this.dateTimeCalendar.ValueChanged += new System.EventHandler(this.dateTimeCalendar_ValueChanged);
            // 
            // textAlarme
            // 
            this.textAlarme.Enabled = false;
            this.textAlarme.Location = new System.Drawing.Point(24, 170);
            this.textAlarme.Name = "textAlarme";
            this.textAlarme.Size = new System.Drawing.Size(314, 20);
            this.textAlarme.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(546, 31);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(108, 28);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(546, 282);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(108, 28);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(546, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelEntrerText
            // 
            this.labelEntrerText.AutoSize = true;
            this.labelEntrerText.Enabled = false;
            this.labelEntrerText.Location = new System.Drawing.Point(21, 154);
            this.labelEntrerText.Name = "labelEntrerText";
            this.labelEntrerText.Size = new System.Drawing.Size(131, 13);
            this.labelEntrerText.TabIndex = 4;
            this.labelEntrerText.Text = "Entrer votre texte d\'alerte :";
            // 
            // HeureUpDown
            // 
            this.HeureUpDown.Location = new System.Drawing.Point(106, 69);
            this.HeureUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HeureUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.HeureUpDown.Name = "HeureUpDown";
            this.HeureUpDown.Size = new System.Drawing.Size(42, 20);
            this.HeureUpDown.TabIndex = 2;
            this.HeureUpDown.ValueChanged += new System.EventHandler(this.HeureUpDown_ValueChanged);
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Location = new System.Drawing.Point(35, 13);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(33, 13);
            this.labelJour.TabIndex = 6;
            this.labelJour.Text = "Jour :";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Location = new System.Drawing.Point(35, 71);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(42, 13);
            this.labelHeure.TabIndex = 6;
            this.labelHeure.Text = "Heure :";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(203, 71);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(45, 13);
            this.labelMinute.TabIndex = 6;
            this.labelMinute.Text = "Minute :";
            // 
            // MinuteUpDown
            // 
            this.MinuteUpDown.Location = new System.Drawing.Point(264, 69);
            this.MinuteUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MinuteUpDown.Name = "MinuteUpDown";
            this.MinuteUpDown.Size = new System.Drawing.Size(42, 20);
            this.MinuteUpDown.TabIndex = 2;
            this.MinuteUpDown.ValueChanged += new System.EventHandler(this.MinuteUpDown_ValueChanged);
            // 
            // groupAlarme
            // 
            this.groupAlarme.Controls.Add(this.radioShutdown);
            this.groupAlarme.Controls.Add(this.radioTextAlarm);
            this.groupAlarme.Controls.Add(this.labelMinute);
            this.groupAlarme.Controls.Add(this.labelHeure);
            this.groupAlarme.Controls.Add(this.labelJour);
            this.groupAlarme.Controls.Add(this.MinuteUpDown);
            this.groupAlarme.Controls.Add(this.HeureUpDown);
            this.groupAlarme.Controls.Add(this.labelEntrerText);
            this.groupAlarme.Controls.Add(this.textAlarme);
            this.groupAlarme.Controls.Add(this.dateTimeCalendar);
            this.groupAlarme.Enabled = false;
            this.groupAlarme.Location = new System.Drawing.Point(17, 108);
            this.groupAlarme.Name = "groupAlarme";
            this.groupAlarme.Size = new System.Drawing.Size(350, 222);
            this.groupAlarme.TabIndex = 7;
            this.groupAlarme.TabStop = false;
            this.groupAlarme.Text = "Alarme";
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Location = new System.Drawing.Point(246, 120);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(92, 17);
            this.radioShutdown.TabIndex = 7;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Eteindre le PC";
            this.radioShutdown.UseVisualStyleBackColor = true;
            // 
            // radioTextAlarm
            // 
            this.radioTextAlarm.AutoSize = true;
            this.radioTextAlarm.Location = new System.Drawing.Point(28, 120);
            this.radioTextAlarm.Name = "radioTextAlarm";
            this.radioTextAlarm.Size = new System.Drawing.Size(91, 17);
            this.radioTextAlarm.TabIndex = 7;
            this.radioTextAlarm.TabStop = true;
            this.radioTextAlarm.Text = "Saisir un texte";
            this.radioTextAlarm.UseVisualStyleBackColor = true;
            this.radioTextAlarm.CheckedChanged += new System.EventHandler(this.radioTextAlarm_CheckedChanged);
            // 
            // groupMinuteur
            // 
            this.groupMinuteur.Controls.Add(this.radio12heure);
            this.groupMinuteur.Controls.Add(this.radio4heure);
            this.groupMinuteur.Controls.Add(this.radioheure);
            this.groupMinuteur.Controls.Add(this.radio6heure);
            this.groupMinuteur.Controls.Add(this.radio2heure);
            this.groupMinuteur.Controls.Add(this.radiodemiheure);
            this.groupMinuteur.Enabled = false;
            this.groupMinuteur.Location = new System.Drawing.Point(373, 108);
            this.groupMinuteur.Name = "groupMinuteur";
            this.groupMinuteur.Size = new System.Drawing.Size(115, 222);
            this.groupMinuteur.TabIndex = 8;
            this.groupMinuteur.TabStop = false;
            this.groupMinuteur.Text = "Minuteur";
            // 
            // radio12heure
            // 
            this.radio12heure.AutoSize = true;
            this.radio12heure.Location = new System.Drawing.Point(6, 180);
            this.radio12heure.Name = "radio12heure";
            this.radio12heure.Size = new System.Drawing.Size(68, 17);
            this.radio12heure.TabIndex = 0;
            this.radio12heure.TabStop = true;
            this.radio12heure.Tag = "120";
            this.radio12heure.Text = "2 Heures";
            this.radio12heure.UseVisualStyleBackColor = true;
            this.radio12heure.CheckedChanged += new System.EventHandler(this.radio12heure_CheckedChanged);
            // 
            // radio4heure
            // 
            this.radio4heure.AutoSize = true;
            this.radio4heure.Location = new System.Drawing.Point(6, 120);
            this.radio4heure.Name = "radio4heure";
            this.radio4heure.Size = new System.Drawing.Size(76, 17);
            this.radio4heure.TabIndex = 0;
            this.radio4heure.TabStop = true;
            this.radio4heure.Tag = "30";
            this.radio4heure.Text = "30 minutes";
            this.radio4heure.UseVisualStyleBackColor = true;
            this.radio4heure.CheckedChanged += new System.EventHandler(this.radio4heure_CheckedChanged);
            // 
            // radioheure
            // 
            this.radioheure.AutoSize = true;
            this.radioheure.Location = new System.Drawing.Point(6, 60);
            this.radioheure.Name = "radioheure";
            this.radioheure.Size = new System.Drawing.Size(76, 17);
            this.radioheure.TabIndex = 0;
            this.radioheure.TabStop = true;
            this.radioheure.Tag = "10";
            this.radioheure.Text = "10 minutes";
            this.radioheure.UseVisualStyleBackColor = true;
            this.radioheure.CheckedChanged += new System.EventHandler(this.radioheure_CheckedChanged);
            // 
            // radio6heure
            // 
            this.radio6heure.AutoSize = true;
            this.radio6heure.Location = new System.Drawing.Point(6, 150);
            this.radio6heure.Name = "radio6heure";
            this.radio6heure.Size = new System.Drawing.Size(63, 17);
            this.radio6heure.TabIndex = 0;
            this.radio6heure.TabStop = true;
            this.radio6heure.Tag = "60";
            this.radio6heure.Text = "1 Heure";
            this.radio6heure.UseVisualStyleBackColor = true;
            this.radio6heure.CheckedChanged += new System.EventHandler(this.radio6heure_CheckedChanged);
            // 
            // radio2heure
            // 
            this.radio2heure.AutoSize = true;
            this.radio2heure.Location = new System.Drawing.Point(6, 90);
            this.radio2heure.Name = "radio2heure";
            this.radio2heure.Size = new System.Drawing.Size(76, 17);
            this.radio2heure.TabIndex = 0;
            this.radio2heure.TabStop = true;
            this.radio2heure.Tag = "15";
            this.radio2heure.Text = "15 minutes";
            this.radio2heure.UseVisualStyleBackColor = true;
            this.radio2heure.CheckedChanged += new System.EventHandler(this.radio2heure_CheckedChanged);
            // 
            // radiodemiheure
            // 
            this.radiodemiheure.AutoSize = true;
            this.radiodemiheure.Location = new System.Drawing.Point(6, 30);
            this.radiodemiheure.Name = "radiodemiheure";
            this.radiodemiheure.Size = new System.Drawing.Size(70, 17);
            this.radiodemiheure.TabIndex = 0;
            this.radiodemiheure.TabStop = true;
            this.radiodemiheure.Tag = "5";
            this.radiodemiheure.Text = "5 minutes";
            this.radiodemiheure.UseVisualStyleBackColor = true;
            this.radiodemiheure.CheckedChanged += new System.EventHandler(this.radiodemiheure_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinuteurCheck);
            this.groupBox3.Controls.Add(this.AlarmeCheck);
            this.groupBox3.Location = new System.Drawing.Point(17, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 71);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fonction :";
            // 
            // MinuteurCheck
            // 
            this.MinuteurCheck.AutoSize = true;
            this.MinuteurCheck.Location = new System.Drawing.Point(158, 29);
            this.MinuteurCheck.Name = "MinuteurCheck";
            this.MinuteurCheck.Size = new System.Drawing.Size(66, 17);
            this.MinuteurCheck.TabIndex = 0;
            this.MinuteurCheck.TabStop = true;
            this.MinuteurCheck.Text = "Minuteur";
            this.MinuteurCheck.UseVisualStyleBackColor = true;
            this.MinuteurCheck.CheckedChanged += new System.EventHandler(this.MinuteurCheck_CheckedChanged);
            // 
            // AlarmeCheck
            // 
            this.AlarmeCheck.AutoSize = true;
            this.AlarmeCheck.Location = new System.Drawing.Point(15, 29);
            this.AlarmeCheck.Name = "AlarmeCheck";
            this.AlarmeCheck.Size = new System.Drawing.Size(57, 17);
            this.AlarmeCheck.TabIndex = 0;
            this.AlarmeCheck.TabStop = true;
            this.AlarmeCheck.Text = "Alarme";
            this.AlarmeCheck.UseVisualStyleBackColor = true;
            this.AlarmeCheck.CheckedChanged += new System.EventHandler(this.AlarmeCheck_CheckedChanged);
            // 
            // groupTypeMin
            // 
            this.groupTypeMin.Controls.Add(this.radioRepeat);
            this.groupTypeMin.Controls.Add(this.radio1fois);
            this.groupTypeMin.Enabled = false;
            this.groupTypeMin.Location = new System.Drawing.Point(266, 31);
            this.groupTypeMin.Name = "groupTypeMin";
            this.groupTypeMin.Size = new System.Drawing.Size(262, 71);
            this.groupTypeMin.TabIndex = 10;
            this.groupTypeMin.TabStop = false;
            this.groupTypeMin.Text = "Type de minuteur :";
            // 
            // radioRepeat
            // 
            this.radioRepeat.AutoSize = true;
            this.radioRepeat.Location = new System.Drawing.Point(148, 29);
            this.radioRepeat.Name = "radioRepeat";
            this.radioRepeat.Size = new System.Drawing.Size(64, 17);
            this.radioRepeat.TabIndex = 0;
            this.radioRepeat.TabStop = true;
            this.radioRepeat.Text = "Répétitif";
            this.radioRepeat.UseVisualStyleBackColor = true;
            // 
            // radio1fois
            // 
            this.radio1fois.AutoSize = true;
            this.radio1fois.Location = new System.Drawing.Point(10, 29);
            this.radio1fois.Name = "radio1fois";
            this.radio1fois.Size = new System.Drawing.Size(72, 17);
            this.radio1fois.TabIndex = 0;
            this.radio1fois.TabStop = true;
            this.radio1fois.Text = "1 seul fois";
            this.radio1fois.UseVisualStyleBackColor = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // LabelAlarmText
            // 
            this.LabelAlarmText.AutoSize = true;
            this.LabelAlarmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlarmText.ForeColor = System.Drawing.Color.Red;
            this.LabelAlarmText.Location = new System.Drawing.Point(497, 150);
            this.LabelAlarmText.Name = "LabelAlarmText";
            this.LabelAlarmText.Size = new System.Drawing.Size(174, 24);
            this.LabelAlarmText.TabIndex = 11;
            this.LabelAlarmText.Text = "ALARME ACTIVE";
            this.LabelAlarmText.Visible = false;
            // 
            // labelAlarmDate
            // 
            this.labelAlarmDate.AutoSize = true;
            this.labelAlarmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmDate.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmDate.Location = new System.Drawing.Point(533, 198);
            this.labelAlarmDate.Name = "labelAlarmDate";
            this.labelAlarmDate.Size = new System.Drawing.Size(66, 24);
            this.labelAlarmDate.TabIndex = 11;
            this.labelAlarmDate.Text = "label1";
            this.labelAlarmDate.Visible = false;
            // 
            // labelAlarmHeure
            // 
            this.labelAlarmHeure.AutoSize = true;
            this.labelAlarmHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmHeure.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmHeure.Location = new System.Drawing.Point(533, 228);
            this.labelAlarmHeure.Name = "labelAlarmHeure";
            this.labelAlarmHeure.Size = new System.Drawing.Size(66, 24);
            this.labelAlarmHeure.TabIndex = 11;
            this.labelAlarmHeure.Text = "label1";
            this.labelAlarmHeure.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 340);
            this.Controls.Add(this.labelAlarmHeure);
            this.Controls.Add(this.labelAlarmDate);
            this.Controls.Add(this.LabelAlarmText);
            this.Controls.Add(this.groupTypeMin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupMinuteur);
            this.Controls.Add(this.groupAlarme);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alarme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteUpDown)).EndInit();
            this.groupAlarme.ResumeLayout(false);
            this.groupAlarme.PerformLayout();
            this.groupMinuteur.ResumeLayout(false);
            this.groupMinuteur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupTypeMin.ResumeLayout(false);
            this.groupTypeMin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimeCalendar;
        private System.Windows.Forms.TextBox textAlarme;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelEntrerText;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown HeureUpDown;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.NumericUpDown MinuteUpDown;
        private System.Windows.Forms.GroupBox groupAlarme;
        private System.Windows.Forms.GroupBox groupMinuteur;
        private System.Windows.Forms.RadioButton radio12heure;
        private System.Windows.Forms.RadioButton radio4heure;
        private System.Windows.Forms.RadioButton radioheure;
        private System.Windows.Forms.RadioButton radio6heure;
        private System.Windows.Forms.RadioButton radio2heure;
        private System.Windows.Forms.RadioButton radiodemiheure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MinuteurCheck;
        private System.Windows.Forms.RadioButton AlarmeCheck;
        private System.Windows.Forms.GroupBox groupTypeMin;
        private System.Windows.Forms.RadioButton radioRepeat;
        private System.Windows.Forms.RadioButton radio1fois;
        private System.Windows.Forms.RadioButton radioShutdown;
        private System.Windows.Forms.RadioButton radioTextAlarm;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label LabelAlarmText;
        private System.Windows.Forms.Label labelAlarmDate;
        private System.Windows.Forms.Label labelAlarmHeure;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

