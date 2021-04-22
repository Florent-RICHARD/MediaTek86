﻿using MediaTek86.controle;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class frmGererAbsence : Form
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private int idmotif;
        private string nom;
        private string prenom;

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        public BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        public BindingSource bdgMotif = new BindingSource();

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Permet de changer la valeur de idpersonnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void SetIdPersonnel(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
        }
        /// <summary>
        /// Permet de changer la valeur de idmotif
        /// </summary>
        /// <param name="idmotif"></param>
        public void SetIdMotif(int idmotif)
        {
            this.idmotif = idmotif;
        }
        /// <summary>
        /// Permet de changer la valeur du nom
        /// </summary>
        /// <param name="nom"></param>
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Permet de changer la valeur du prenom
        /// </summary>
        /// <param name="prenom"></param>
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        /// <summary>
        /// Retourne idpersonnel
        /// </summary>
        /// <returns></returns>
        public int GetIdPersonnel()
        {
            return idpersonnel;
        }
        /// <summary>
        /// Retourne idmotif
        /// </summary>
        /// <returns></returns>
        public int GetIdMotif()
        {
            return idmotif;
        }
        /// <summary>
        /// Retourne nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }
        /// <summary>
        /// Retourne prenom
        /// </summary>
        /// <returns></returns>
        public string GetPrenom()
        {
            return prenom;
        }

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public frmGererAbsence(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListeMotif();
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
        }

        private void frmGererAbsence_Load(object sender, EventArgs e)
        {
            txtNom.Text = GetNom();
            txtPrenom.Text = GetPrenom();
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        public void RemplirListeMotif()
        {
            controle.GetLesMotifs(bdgMotif);
            cbbMotif.DataSource = bdgMotif;
            if (cbbMotif.Items.Count > 0)
            {
                cbbMotif.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirListeAbsence(Personnel personnel)
        {
            controle.GetLesAbsences(personnel, bdgAbsence);
            dgvAbsence.DataSource = bdgAbsence;
            dgvAbsence.Columns["idmotif"].Visible = false;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.Columns["nom"].Visible = false;
            dgvAbsence.Columns["prenom"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnRetourListePerso_Click(object sender, EventArgs e)
        {
            controle.RetourListePerso();
        }
    }
}
