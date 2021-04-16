namespace MediaTek86.vue
{
    partial class frmListePersonnel
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
            this.lstListePersonnel = new System.Windows.Forms.ListBox();
            this.btnSupPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnGererAbsence = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListePersonnel
            // 
            this.lstListePersonnel.FormattingEnabled = true;
            this.lstListePersonnel.Location = new System.Drawing.Point(25, 11);
            this.lstListePersonnel.Name = "lstListePersonnel";
            this.lstListePersonnel.Size = new System.Drawing.Size(707, 277);
            this.lstListePersonnel.TabIndex = 0;
            // 
            // btnSupPersonnel
            // 
            this.btnSupPersonnel.Location = new System.Drawing.Point(25, 298);
            this.btnSupPersonnel.Name = "btnSupPersonnel";
            this.btnSupPersonnel.Size = new System.Drawing.Size(182, 23);
            this.btnSupPersonnel.TabIndex = 1;
            this.btnSupPersonnel.Text = "Supprimer du personnel";
            this.btnSupPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(286, 298);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(182, 23);
            this.btnModifPersonnel.TabIndex = 2;
            this.btnModifPersonnel.Text = "Modifier le personnel";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnGererAbsence
            // 
            this.btnGererAbsence.Location = new System.Drawing.Point(550, 298);
            this.btnGererAbsence.Name = "btnGererAbsence";
            this.btnGererAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnGererAbsence.TabIndex = 3;
            this.btnGererAbsence.Text = "Gérer les absences";
            this.btnGererAbsence.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(21, 342);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 19);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTel.Location = new System.Drawing.Point(21, 372);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(94, 19);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMail.Location = new System.Drawing.Point(22, 402);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 19);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail :";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(121, 371);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(113, 24);
            this.txtTel.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(121, 341);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(113, 24);
            this.txtNom.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(121, 400);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(177, 24);
            this.txtMail.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(312, 342);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(75, 19);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(393, 340);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(113, 24);
            this.txtPrenom.TabIndex = 11;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(312, 372);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(70, 19);
            this.lblService.TabIndex = 12;
            this.lblService.Text = "Service :";
            // 
            // cbbService
            // 
            this.cbbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Items.AddRange(new object[] {
            "Administratif",
            "Mediation Culturelle",
            "Pret"});
            this.cbbService.Location = new System.Drawing.Point(393, 374);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(152, 26);
            this.cbbService.TabIndex = 13;
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(121, 439);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(182, 23);
            this.btnAjouterPersonnel.TabIndex = 14;
            this.btnAjouterPersonnel.Text = "Ajouter au personnel";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // frmListePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.cbbService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnGererAbsence);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnSupPersonnel);
            this.Controls.Add(this.lstListePersonnel);
            this.Name = "frmListePersonnel";
            this.Text = "Liste Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListePersonnel;
        private System.Windows.Forms.Button btnSupPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnGererAbsence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.Button btnAjouterPersonnel;
    }
}