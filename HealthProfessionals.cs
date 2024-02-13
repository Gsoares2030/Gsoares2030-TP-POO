/*HealthProfessional.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 8/12/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/

using ObjetoNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;


namespace DL
{
    /// <summary>
    /// Health Professionals
    /// </summary>
    [Serializable]
    public class HealthProfessionals
    {
        /// <summary>
        /// Dictionaries 
        /// </summary>
        [NonSerialized]
        static Dictionary<int, List<HealthProfessional>> healthProfessionals;
        static Dictionary<int, List<HealthProfessional>> clonedDictionary;


        #region Methods

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        static HealthProfessionals()
        {
            healthProfessionals = new Dictionary<int, List<HealthProfessional>>();
            clonedDictionary = new Dictionary<int, List<HealthProfessional>>();

        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method of inserting a set of biometric data from a Healthcare Professional into the list.
        /// </summary>
        /// <param name="id">ID Professional</param>
        /// <param name="hp">HealthProfessional</param>
        /// <returns>Returns true if the HealthProfessional was added to the list. Returns false if this HealthProfessional already exists in the list</returns>
        public static bool InsertHealthProfessional(int id,HealthProfessional hp)
        {
            if (!healthProfessionals.ContainsKey(id))
                healthProfessionals.Add(id, new List<HealthProfessional>());
            if (!healthProfessionals[id].Contains(hp))
            {
                healthProfessionals[id].Add(hp);
                return true;
                
            }
            return false;
            
        }

        /// <summary>
        /// Receives the Healthcare Professional's ID and a set of biometric data from that same professional.
        /// Then check if the ID of that professional exists in the list, if it exists, check if there is a record of the biometric data passed by parameter in the list.
        /// </summary>
        /// <param name="id">Professional ID</param>
        /// <param name="h">HealthProfessional</param>
        /// <returns>Returns true if it exists and false otherwise</returns>
        public static bool ExistsHealthProfessional(int id,HealthProfessional h)
        {
            if (healthProfessionals.ContainsKey(id))
            {
                if (healthProfessionals[id].Contains(h))
                {
                    return true;
                }
                else return false;
            }
            throw new Exception("O registo não existe");
        }


        /// <summary>
        /// The function receives a record to be removed, the ID to which that record belongs, then checks if that ID exists in the system. 
        /// If it exists, it then verifies whether the record itself exists.
        /// If the record also exists, the system proceeds to remove that record from the system.
        /// </summary>
        /// <param name="hp">HealthProfessional</param>
        /// <param name="id">HealthProfessional ID</param>
        /// <returns>Returns true if the record is removed and false if the professional's ID is not found in the system</returns>
        public static bool RemoveHealthProfessionalRegist(int id,HealthProfessional hp)
        {
            if (healthProfessionals.ContainsKey(id))
            {
                if (healthProfessionals[id].Contains(hp))
                {
                    healthProfessionals[id].Remove(hp);
                    return true;
                }
                throw new Exception("O registo a remover não existe");
            }
            return false;

        }





        /// <summary>
        ///Copy the entire dictionary
        /// </summary>
        /// <returns>Return the clone of dictionary healthProfessional </returns>
        public static Dictionary<int, List<HealthProfessional>> Dictinary()
        {

            clonedDictionary = healthProfessionals.ToDictionary(entry => entry.Key, entry => entry.Value);
            return clonedDictionary;

        }


        /// <summary>
        /// The function shows the dictionary of healthprofessionals
        /// </summary>
        public static bool ShowDictinary()
        {
            HealthProfessionals.Dictinary();
            foreach (KeyValuePair<int, List<HealthProfessional>> entry in clonedDictionary)
            {
                Console.WriteLine($"ID: {entry.Key}");

                foreach (HealthProfessional healthProfessional in entry.Value)
                {
                    Console.WriteLine("" + healthProfessional.ToString());
                    
                }

            }
            return true;
        }



        /// <summary>
        /// Clear dictinary
        /// </summary>
        /// <returns>Return true if sucess</returns>
        public static bool Clear()
        {
            healthProfessionals.Clear();
            return true;
        }



        /// <summary>
        /// Stores regists in binary format
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool SaveHealthProfessional(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, healthProfessionals);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                throw e;
            }
        }


        /// <summary>
        /// Read registers in binary format
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool LoadHealthProfessional(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    healthProfessionals = (Dictionary<int,List<HealthProfessional>>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (FileLoadException e)
                {
                    Console.Write("ERRO:" + e.Message);
                    throw e;
                }
            }
            return false;
        }


        #endregion

        #region Destructor
        /// <summary>
        /// Destructor by default
        /// </summary>
        ~HealthProfessionals()
        {
        }
        #endregion

        #endregion

    }
}
