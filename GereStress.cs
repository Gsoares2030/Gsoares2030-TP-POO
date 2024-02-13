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
    /// Gere Stress
    /// </summary>
    public class GereStress
    {
        /// <summary>
        /// The function checks whether the biometric data is valid
        /// </summary>
        /// <param name="id">Professinal ID</param>
        /// <param name="hp">HealthProfessional</param>
        /// <returns>Returns by calling the InsertHealthProfessional function</returns>
        public static bool InsertHealthProfessional(int id,HealthProfessional hp)
        {
            if(hp.FC >=40 && hp.FR >=12 && hp.TemCorp>33.5)
            {
                return HealthProfessionals.InsertHealthProfessional(id,hp);
            }
            throw new Exception("O parametros de fc e fr não são validos");
        }

        /// <summary>
        /// The function checks whether the ID is valid
        /// </summary>
        /// <param name="id">Professinal ID</param>
        /// <param name="hp">HealthProfessional</param>
        /// <returns>>Returns by calling the ExistsHealthProfessional function</returns>
        public static bool ExistsHealthProfessional(int id, HealthProfessional hp)
        {
            if(id!=0)
            {
                return HealthProfessionals.ExistsHealthProfessional(id,hp);
            }
            throw new Exception("O id do Profissional de Saude a procurar tem de ser maior que 0");
        }



        /// <summary>
        /// The function checks whether the biometric data is valid and verifies whether the ID is valid
        /// </summary>
        /// <param name="hp">HealthProfessional</param>
        /// <param name="id">Professinal ID</param>
        /// <returns>Returns by calling the RemoveHealthProfessionalRegist function</returns>
        public static bool RemoveHealthProfessionalRegist(HealthProfessional hp, int id)
        {
            if(hp.FC >= 40 && hp.FR >= 12 && hp.TemCorp > 33.9)
            {
                if(id != 0)
                {
                    return HealthProfessionals.RemoveHealthProfessionalRegist(id,hp);
                }
                throw new Exception("O id do Profissional de Saude tem de ser maior que 0");
            }
            throw new Exception("O parametros de fc e fr não são validos");
        }


        /// <summary>
        /// Function that calls the Clear function
        /// </summary>
        /// <returns>Returns the result of the Clear function</returns>
        public static bool Clear()
        {

            return HealthProfessionals.Clear();

        }

        /// <summary>
        /// Function checks whether the path passed by parameter is null, if not, it calls the Save function
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns>Retorna o resultado da função Guardar</returns>
        public static bool SaveHealthProfessional(string fileName)
        {
            if (fileName != "" )
            {
                return HealthProfessionals.SaveHealthProfessional(fileName);
            }
            throw new Exception("Caminho nulo");
        }


        /// <summary>
        /// Function checks whether the path passed by parameter is null, if not, it calls the Load function
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns>Returns the result of the Load function</returns>
        public static bool LoadHealthProfessional(string fileName)
        {
            if (fileName != "")
            {
                return HealthProfessionals.LoadHealthProfessional(fileName);
            }
            throw new Exception("Caminho nulo");
        }

        /// <summary>
        /// Show Dictionary of HealthProfessionals
        /// </summary>
        public static bool ShowDictinary()
        {
            return HealthProfessionals.ShowDictinary();
            
        }
      
    }
}
