/*GereStress.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 08/12/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/

using System;
using System.Collections.Generic;
using DL;
using ObjetoNegocio;
namespace BL
{
    /// <summary>
    /// Gere Professionals
    /// </summary>
    public class GereProfessionals
    {
       

        /// <summary>
        /// Function that checks whether the age and name comply with the application's business rules
        /// </summary>
        /// <param name="p">Professinal</param>
        /// <returns>Returns the result of inserting the professional into the list of professionals</returns>
        public static bool InsertProfessional(Professional p)
        {
            if (p.Name!=null && p.Age>18)
            {
                return Professionals.InsertProfessional(p);
            }
            throw new Exception("O parametros nome e idade não são validos");
        }


        /// <summary>
        /// Function that checks if the Id is not null, if so, checks if it exists.
        /// </summary>
        /// <param name="p">Professinal</param>
        /// <returns>Returns the result of the ExistsProfessional function</returns>
        public static bool ExistsProfessional(Professional p)
        {
            if (p.ID != 0)
            {
                return Professionals.ExistsProfessional(p);
            }
            throw new Exception("O id do Profissional a procurar tem de ser maior que 0");
        }


        /// <summary>
        /// Function that checks if the Id is not null, if so, remove it.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Returns the result of the RemovePofessionalRegist function</returns>
        public static bool RemoverPofessionalRegist(Professional p)
        {
                if (p.ID != 0)
                {
                    return Professionals.RemoveProfessionalRegist(p);
                }
                throw new Exception("O id do Profissional tem de ser maior que 0");
        }


        /// <summary>
        /// Function that calls the Clear function
        /// </summary>
        /// <returns>Returns the result of the Clear function</returns>
        public static bool Clear()
        {

            return Professionals.Clear();

        }

        /// <summary>
        /// Function checks whether the path passed by parameter is null, if not, it calls the Save function
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns>Returns the result of the Save function</returns>
        public static bool SaveProfessional(string fileName)
        {
            if (fileName != "")
            {
                return Professionals.SaveProfessional(fileName);
            }
            throw new Exception("Caminho nulo");
        }

        /// <summary>
        /// Function checks whether the path passed by parameter is null, if not, it calls the Load function
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns>Returns the result of the Load function</returns>
        public static bool LoadProfessional(string fileName)
        {
            if (fileName != "")
            {
                return Professionals.LoadProfessional(fileName);
            }
            throw new Exception("Caminho nulo");
        }


        /// <summary>
        /// Show Dictinary of Professionals
        /// </summary>
        public static bool ShowProfessionals()
        {
            return Professionals.ShowDictinary();
        }

    }
}

