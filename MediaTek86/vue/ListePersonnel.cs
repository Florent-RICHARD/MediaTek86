using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.modele;
using MediaTek86.controle;

namespace MediaTek86.vue
{
    public partial class frmListePersonnel : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        public BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        public BindingSource bdgService = new BindingSource();
        public frmListePersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Affiche ou non les zones de texte pour ajouter un personnel
        /// </summary>
        /// <param name="boolean"></param>
        public void GererZoneTexte(Boolean boolean)
        {
            lblNom.Visible = boolean;
            lblPrenom.Visible = boolean;
            lblTel.Visible = boolean;
            lblMail.Visible = boolean;
            lblService.Visible = boolean;
            txtNom.Visible = boolean;
            txtPrenom.Visible = boolean;
            txtTel.Visible = boolean;
            txtMail.Visible = boolean;
            cbbService.Visible = boolean;
            btnEnregistrerPersonnel.Visible = boolean;
            btnAnnulerAjout.Visible = boolean;
        }

        /// <summary>
        /// Vide les zones de saisies
        /// </summary>
        public void ViderZoneTexte()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";

        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListePersonnel();
            RemplirListeService();
            GererZoneTexte(false);
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirListeService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cbbService.DataSource = bdgService;
            if (cbbService.Items.Count > 0)
            {
                cbbService.SelectedIndex = 0;
            }
        }

        private void btnAjouterPersonnel_Click(object sender, EventArgs e)
        {
            GererZoneTexte(true);
        }

        /// <summary>
        /// Annule l'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            GererZoneTexte(false);
            ViderZoneTexte();
        }

        /// <summary>
        /// Enregistre et ajoute un personnel à la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cbbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = 0;
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                controle.AddDeveloppeur(personnel);
                RemplirListePersonnel();
                ViderZoneTexte();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Supprime un personnel de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
