namespace Club_de_go_Senthé
{
    partial class FrmEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpListeJoueurs = new System.Windows.Forms.GroupBox();
            this.lsvListeJoueur = new System.Windows.Forms.ListView();
            this.col_Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_noMembreCga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_courriel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpListeJoueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListeJoueurs
            // 
            this.grpListeJoueurs.Controls.Add(this.lsvListeJoueur);
            this.grpListeJoueurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListeJoueurs.Location = new System.Drawing.Point(0, 0);
            this.grpListeJoueurs.Name = "grpListeJoueurs";
            this.grpListeJoueurs.Size = new System.Drawing.Size(785, 509);
            this.grpListeJoueurs.TabIndex = 0;
            this.grpListeJoueurs.TabStop = false;
            this.grpListeJoueurs.Text = "Liste des joueurs";
            // 
            // lsvListeJoueur
            // 
            this.lsvListeJoueur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvListeJoueur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Nom,
            this.col_noMembreCga,
            this.col_rang,
            this.col_courriel,
            this.col_telephone,
            this.col_adresse});
            this.lsvListeJoueur.FullRowSelect = true;
            this.lsvListeJoueur.GridLines = true;
            this.lsvListeJoueur.Location = new System.Drawing.Point(6, 19);
            this.lsvListeJoueur.Name = "lsvListeJoueur";
            this.lsvListeJoueur.Size = new System.Drawing.Size(767, 478);
            this.lsvListeJoueur.TabIndex = 0;
            this.lsvListeJoueur.UseCompatibleStateImageBehavior = false;
            this.lsvListeJoueur.View = System.Windows.Forms.View.Details;
            // 
            // col_Nom
            // 
            this.col_Nom.Text = "Nom";
            this.col_Nom.Width = 153;
            // 
            // col_noMembreCga
            // 
            this.col_noMembreCga.Text = "No membre CGA";
            this.col_noMembreCga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_noMembreCga.Width = 100;
            // 
            // col_rang
            // 
            this.col_rang.Text = "Rang";
            this.col_rang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_rang.Width = 63;
            // 
            // col_courriel
            // 
            this.col_courriel.Text = "Courriel";
            this.col_courriel.Width = 145;
            // 
            // col_telephone
            // 
            this.col_telephone.Text = "Téléphone";
            this.col_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_telephone.Width = 112;
            // 
            // col_adresse
            // 
            this.col_adresse.Text = "Adresse";
            this.col_adresse.Width = 188;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpActions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpListeJoueurs);
            this.splitContainer1.Size = new System.Drawing.Size(949, 509);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnSupprimer);
            this.grpActions.Controls.Add(this.btnModifier);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActions.Location = new System.Drawing.Point(0, 0);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(160, 509);
            this.grpActions.TabIndex = 0;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(6, 48);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(148, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Enabled = false;
            this.btnModifier.Location = new System.Drawing.Point(6, 19);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(148, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.membresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnMembreToolStripMenuItem});
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membresToolStripMenuItem.Text = "Membres";
            // 
            // ajouterUnMembreToolStripMenuItem
            // 
            this.ajouterUnMembreToolStripMenuItem.Name = "ajouterUnMembreToolStripMenuItem";
            this.ajouterUnMembreToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ajouterUnMembreToolStripMenuItem.Text = "Ajouter un membre...";
            this.ajouterUnMembreToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMembreToolStripMenuItem_Click);
            // 
            // FrmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 548);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmEmploye";
            this.Text = "FrmEmploye";
            this.grpListeJoueurs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpActions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListeJoueurs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lsvListeJoueur;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMembreToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader col_Nom;
        private System.Windows.Forms.ColumnHeader col_noMembreCga;
        private System.Windows.Forms.ColumnHeader col_rang;
        private System.Windows.Forms.ColumnHeader col_courriel;
        private System.Windows.Forms.ColumnHeader col_telephone;
        private System.Windows.Forms.ColumnHeader col_adresse;
    }
}