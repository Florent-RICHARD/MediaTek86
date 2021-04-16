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
        private string datedebut;
        private string datefin;
        private int idmotif;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(int idpersonnel, string datedebut, string datefin, int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
        }
    }
}
