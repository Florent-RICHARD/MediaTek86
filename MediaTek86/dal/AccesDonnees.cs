using MediaTek86.connexion;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{

    public class AccesDonnees
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// /// </summary>
        private static string connectionString = "server=localhost;user id=admin;password=wHIwAcI3DijYBRvO;database=mediatek86;SslMode=none";

        /// <summary>
        /// Récupère et retourne le personnel provenant de la BDD
        /// </summary>
        /// <returns>liste du personnel</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select idpersonnel, p.nom as nom, prenom, tel, mail, s.idservice as idservice, s.nom as service ";
            req += "from personnel p JOIN service s ON p.idservice = s.idservice ";
            req += "order by nom";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select * from service order by nom";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
            req += "values (@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

    }

}
