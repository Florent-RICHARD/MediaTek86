using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    class Service
    {
        // Déclaration des propriétés
        private int idservice;
        private string nom;

        /// <summary>
        /// Retourne idService
        /// </summary>
        /// <returns></returns>
        public int GetIdService()
        {
            return idservice;
        }

        /// <summary>
        /// Retourne le nom
        /// </summary>
        /// <returns></returns>
        public string GetNom()
        {
            return nom;
        }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom )
        {
            this.idservice = idservice;
            this.nom = nom;
        }

    }
}
