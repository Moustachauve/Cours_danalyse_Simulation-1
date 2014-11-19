namespace Club_de_go_Senthé
{
    partial class FrmAjouterJoueur
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
            this.grpAjouterJoueur = new System.Windows.Forms.GroupBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCourrielOptionnel = new System.Windows.Forms.Label();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblRue = new System.Windows.Forms.Label();
            this.txtNoCivique = new System.Windows.Forms.TextBox();
            this.lblNoCivique = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtRang = new System.Windows.Forms.TextBox();
            this.lblRang = new System.Windows.Forms.Label();
            this.txtNoMembre = new System.Windows.Forms.TextBox();
            this.lblNoMembre = new System.Windows.Forms.Label();
            this.grpAjouterJoueur.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAjouterJoueur
            // 
            this.grpAjouterJoueur.Controls.Add(this.txtNoMembre);
            this.grpAjouterJoueur.Controls.Add(this.lblNoMembre);
            this.grpAjouterJoueur.Controls.Add(this.txtRang);
            this.grpAjouterJoueur.Controls.Add(this.lblRang);
            this.grpAjouterJoueur.Controls.Add(this.btnEnvoyer);
            this.grpAjouterJoueur.Controls.Add(this.txtTelephone);
            this.grpAjouterJoueur.Controls.Add(this.lblTelephone);
            this.grpAjouterJoueur.Controls.Add(this.lblCourrielOptionnel);
            this.grpAjouterJoueur.Controls.Add(this.txtCourriel);
            this.grpAjouterJoueur.Controls.Add(this.lblCourriel);
            this.grpAjouterJoueur.Controls.Add(this.txtVille);
            this.grpAjouterJoueur.Controls.Add(this.lblVille);
            this.grpAjouterJoueur.Controls.Add(this.txtRue);
            this.grpAjouterJoueur.Controls.Add(this.lblRue);
            this.grpAjouterJoueur.Controls.Add(this.txtNoCivique);
            this.grpAjouterJoueur.Controls.Add(this.lblNoCivique);
            this.grpAjouterJoueur.Controls.Add(this.txtMotDePasse);
            this.grpAjouterJoueur.Controls.Add(this.lblMotDePasse);
            this.grpAjouterJoueur.Controls.Add(this.txtNomUtilisateur);
            this.grpAjouterJoueur.Controls.Add(this.lblNomUtilisateur);
            this.grpAjouterJoueur.Controls.Add(this.txtNom);
            this.grpAjouterJoueur.Controls.Add(this.lblNom);
            this.grpAjouterJoueur.Controls.Add(this.txtPrenom);
            this.grpAjouterJoueur.Controls.Add(this.lblPrenom);
            this.grpAjouterJoueur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAjouterJoueur.Location = new System.Drawing.Point(0, 0);
            this.grpAjouterJoueur.Name = "grpAjouterJoueur";
            this.grpAjouterJoueur.Size = new System.Drawing.Size(353, 449);
            this.grpAjouterJoueur.TabIndex = 0;
            this.grpAjouterJoueur.TabStop = false;
            this.grpAjouterJoueur.Text = "Ajouter un joueur";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnvoyer.Location = new System.Drawing.Point(141, 414);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 19;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelephone.Location = new System.Drawing.Point(12, 305);
            this.txtTelephone.Mask = "(000)-000-0000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(329, 20);
            this.txtTelephone.TabIndex = 18;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 289);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 17;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblCourrielOptionnel
            // 
            this.lblCourrielOptionnel.AutoSize = true;
            this.lblCourrielOptionnel.ForeColor = System.Drawing.Color.Gray;
            this.lblCourrielOptionnel.Location = new System.Drawing.Point(56, 250);
            this.lblCourrielOptionnel.Name = "lblCourrielOptionnel";
            this.lblCourrielOptionnel.Size = new System.Drawing.Size(58, 13);
            this.lblCourrielOptionnel.TabIndex = 16;
            this.lblCourrielOptionnel.Text = "(Optionnel)";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourriel.Location = new System.Drawing.Point(12, 266);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(329, 20);
            this.txtCourriel.TabIndex = 15;
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(12, 250);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(42, 13);
            this.lblCourriel.TabIndex = 14;
            this.lblCourriel.Text = "Courriel";
            // 
            // txtVille
            // 
            this.txtVille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVille.Location = new System.Drawing.Point(12, 227);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(329, 20);
            this.txtVille.TabIndex = 13;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(12, 211);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 12;
            this.lblVille.Text = "Ville";
            // 
            // txtRue
            // 
            this.txtRue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRue.Location = new System.Drawing.Point(89, 188);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(252, 20);
            this.txtRue.TabIndex = 11;
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(89, 172);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(27, 13);
            this.lblRue.TabIndex = 10;
            this.lblRue.Text = "Rue";
            // 
            // txtNoCivique
            // 
            this.txtNoCivique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoCivique.Location = new System.Drawing.Point(12, 188);
            this.txtNoCivique.Name = "txtNoCivique";
            this.txtNoCivique.Size = new System.Drawing.Size(71, 20);
            this.txtNoCivique.TabIndex = 9;
            // 
            // lblNoCivique
            // 
            this.lblNoCivique.AutoSize = true;
            this.lblNoCivique.Location = new System.Drawing.Point(12, 172);
            this.lblNoCivique.Name = "lblNoCivique";
            this.lblNoCivique.Size = new System.Drawing.Size(58, 13);
            this.lblNoCivique.TabIndex = 8;
            this.lblNoCivique.Text = "No civique";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotDePasse.Location = new System.Drawing.Point(12, 149);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(329, 20);
            this.txtMotDePasse.TabIndex = 7;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 133);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 6;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomUtilisateur.Location = new System.Drawing.Point(12, 110);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(329, 20);
            this.txtNomUtilisateur.TabIndex = 5;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(12, 94);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(84, 13);
            this.lblNomUtilisateur.TabIndex = 4;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(12, 71);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(329, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 55);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrenom.Location = new System.Drawing.Point(12, 32);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(329, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 16);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtRang
            // 
            this.txtRang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRang.Location = new System.Drawing.Point(12, 344);
            this.txtRang.Name = "txtRang";
            this.txtRang.Size = new System.Drawing.Size(329, 20);
            this.txtRang.TabIndex = 21;
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(12, 328);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(33, 13);
            this.lblRang.TabIndex = 20;
            this.lblRang.Text = "Rang";
            // 
            // txtNoMembre
            // 
            this.txtNoMembre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoMembre.Location = new System.Drawing.Point(12, 383);
            this.txtNoMembre.Name = "txtNoMembre";
            this.txtNoMembre.Size = new System.Drawing.Size(329, 20);
            this.txtNoMembre.TabIndex = 23;
            // 
            // lblNoMembre
            // 
            this.lblNoMembre.AutoSize = true;
            this.lblNoMembre.Location = new System.Drawing.Point(12, 367);
            this.lblNoMembre.Name = "lblNoMembre";
            this.lblNoMembre.Size = new System.Drawing.Size(86, 13);
            this.lblNoMembre.TabIndex = 22;
            this.lblNoMembre.Text = "No membre CGA";
            // 
            // FrmAjouterJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 449);
            this.Controls.Add(this.grpAjouterJoueur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjouterJoueur";
            this.RightToLeftLayout = true;
            this.Text = "FrmAjouterJoueur";
            this.grpAjouterJoueur.ResumeLayout(false);
            this.grpAjouterJoueur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAjouterJoueur;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNoCivique;
        private System.Windows.Forms.Label lblNoCivique;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCourrielOptionnel;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txtRang;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.TextBox txtNoMembre;
        private System.Windows.Forms.Label lblNoMembre;
    }
}