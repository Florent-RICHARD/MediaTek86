using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Création d'une absence
    /// </summary>
    public class Absence
    {
        // Déclaration des propriétés
        private int idpersonnel;
        private string nom;
        private string prenom;
        private DateTime datedebut;
        private DateTime datefin;
        private int idmotif;
        private string motif;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public DateTime Date_de_debut { get => datedebut; }
        public DateTime Date_de_fin { get => datefin; }
        public int Idmotif { get => idmotif; }
        public string Motif { get => motif; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, string nom, string prenom, DateTime datedebut, DateTime datefin, int idmotif, string motif)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
            this.motif = motif;
        }
    }
}
