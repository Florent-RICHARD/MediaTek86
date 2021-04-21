namespace MediaTek86.vue
{
    partial class frmGererAbsence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.cbbMotif = new System.Windows.Forms.ComboBox();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnRetourListePerso = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupAbsence = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(152, 451);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnAjouterAbsence.TabIndex = 29;
            this.btnAjouterAbsence.Text = "Ajouter l\'absence";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // cbbMotif
            // 
            this.cbbMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbbMotif.FormattingEnabled = true;
            this.cbbMotif.Location = new System.Drawing.Point(152, 419);
            this.cbbMotif.Name = "cbbMotif";
            this.cbbMotif.Size = new System.Drawing.Size(152, 26);
            this.cbbMotif.TabIndex = 28;
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateDebut.Location = new System.Drawing.Point(152, 359);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(113, 24);
            this.txtDateDebut.TabIndex = 23;
            // 
            // txtDateFin
            // 
            this.txtDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFin.Location = new System.Drawing.Point(152, 387);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(113, 24);
            this.txtDateFin.TabIndex = 22;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMotif.Location = new System.Drawing.Point(28, 419);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(55, 19);
            this.lblMotif.TabIndex = 21;
            this.lblMotif.Text = "Motif :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDateFin.Location = new System.Drawing.Point(27, 389);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(97, 19);
            this.lblDateFin.TabIndex = 20;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(27, 359);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(119, 19);
            this.lblDateDebut.TabIndex = 19;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // btnRetourListePerso
            // 
            this.btnRetourListePerso.Location = new System.Drawing.Point(556, 315);
            this.btnRetourListePerso.Name = "btnRetourListePerso";
            this.btnRetourListePerso.Size = new System.Drawing.Size(182, 23);
            this.btnRetourListePerso.TabIndex = 18;
            this.btnRetourListePerso.Text = "Retour à la liste du personnel";
            this.btnRetourListePerso.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(292, 315);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnModifAbsence.TabIndex = 17;
            this.btnModifAbsence.Text = "Modifier l\'absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupAbsence
            // 
            this.btnSupAbsence.Location = new System.Drawing.Point(31, 315);
            this.btnSupAbsence.Name = "btnSupAbsence";
            this.btnSupAbsence.Size = new System.Drawing.Size(182, 23);
            this.btnSupAbsence.TabIndex = 16;
            this.btnSupAbsence.Text = "Supprimer l\'absence";
            this.btnSupAbsence.UseVisualStyleBackColor = true;
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.AllowUserToAddRows = false;
            this.dgvAbsence.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(32, 33);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.ReadOnly = true;
            this.dgvAbsence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAbsence.Size = new System.Drawing.Size(706, 276);
            this.dgvAbsence.TabIndex = 30;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(28, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 19);
            this.lblNom.TabIndex = 31;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(88, 7);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(113, 24);
            this.txtNom.TabIndex = 32;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(250, 9);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(75, 19);
            this.lblPrenom.TabIndex = 33;
            this.lblPrenom.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(331, 7);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(113, 24);
            this.txtPrenom.TabIndex = 34;
            // 
            // frmGererAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.dgvAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.cbbMotif);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.btnRetourListePerso);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnSupAbsence);
            this.Name = "frmGererAbsence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.frmGererAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.ComboBox cbbMotif;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnRetourListePerso;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
    }
}