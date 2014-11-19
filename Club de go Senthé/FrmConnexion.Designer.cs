namespace Club_de_go_Senthé
{
    partial class FrmConnexion
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
            this.grpConnexion = new System.Windows.Forms.GroupBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnexion
            // 
            this.grpConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnexion.Controls.Add(this.btnEnvoyer);
            this.grpConnexion.Controls.Add(this.txtMotDePasse);
            this.grpConnexion.Controls.Add(this.lblMotDePasse);
            this.grpConnexion.Controls.Add(this.txtNumero);
            this.grpConnexion.Controls.Add(this.lblNom);
            this.grpConnexion.Location = new System.Drawing.Point(12, 12);
            this.grpConnexion.Name = "grpConnexion";
            this.grpConnexion.Size = new System.Drawing.Size(229, 146);
            this.grpConnexion.TabIndex = 0;
            this.grpConnexion.TabStop = false;
            this.grpConnexion.Text = "Connexion";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnvoyer.Location = new System.Drawing.Point(77, 113);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 4;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotDePasse.Location = new System.Drawing.Point(9, 87);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(214, 20);
            this.txtMotDePasse.TabIndex = 3;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(6, 71);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(77, 13);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(9, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(214, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(75, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Numéro CGA :";
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 170);
            this.Controls.Add(this.grpConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConnexion";
            this.Text = "Connexion";
            this.grpConnexion.ResumeLayout(false);
            this.grpConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnexion;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNom;

    }
}

