using MediaTek86.controle;
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
    public partial class frmModificationPersonnel : Form
    {
        // Déclaration des propriétés
        public int idpersonnel;
        public string nom;
        public string prenom;
        public string tel;
        public string mail;
        public string service;

        private frmListePersonnel frmListePersonnel;

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        public BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        public frmModificationPersonnel(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListeService();
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirListeService()
        {
            controle.GetLesServices(bdgService);
            cbbService.DataSource = bdgService;
            if (cbbService.Items.Count > 0)
            {
                cbbService.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Remplis les zones de texte au chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModificationPersonnel_Load(object sender, EventArgs e)
        {
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtTel.Text = tel;
            txtMail.Text = mail;
            cbbService.SelectedIndex = cbbService.FindStringExact(service);
        }

        /// <summary>
        /// Annule les modifications et retourne à la liste des personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListePersonnel = new frmListePersonnel(controle);
            frmListePersonnel.ShowDialog();
        }

        /// <summary>
        /// Enregistre les modifications du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerModif_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cbbService.SelectedIndex != -1)
            {
                if (MessageBox.Show("Voulez-vous vraiment enregistrer ?", "Confirmation d'enregistrement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.EnrUpdatePersonnel(txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
                }
                
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
