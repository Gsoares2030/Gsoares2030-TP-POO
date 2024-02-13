using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ObjetoNegocio;

namespace DL
{
    /// <summary>
    /// Professionals
    /// </summary>
    [Serializable]
    public class Professionals
    {
        /// <summary>
        /// Dictionary
        /// </summary>
        
        [NonSerialized]
        static Dictionary<int, List<Professional>> professionals;
        static Dictionary<int, List<Professional>> clonedDictionary;


        /// <summary>
        /// Constructor that creates the dictionary
        /// </summary>
        static Professionals()
        {
           professionals = new Dictionary<int, List<Professional>>();
            clonedDictionary = new Dictionary<int, List<Professional>>();
        }


        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Method for insertion of an Professional on the list
        /// </summary>
        /// <param name="p"> Professional</param>
        /// <returns>Returns true if the professional was added to the list. Returns false if this professional already exists in the list</returns>
        public static bool InsertProfessional(Professional p)
        {
            if (!professionals.ContainsKey(p.ID))
                professionals.Add(p.ID, new List<Professional>());
            if (!professionals[p.ID].Contains(p))
            {
                professionals[p.ID].Add(p);
                return true;

            }
            return false;

        }

        /// <summary>
        /// Receives the professional's ID and checks, based on that same ID, whether there is a record of that professional in the system.
        /// </summary>
        /// <param name="p">Professional</param>
        /// <returns>Returns true if this professional exists in the list. Returns false if there is no registration for this professional.</returns>
        public static bool ExistsProfessional(Professional p)
        {
            if (professionals.ContainsKey(p.ID))
            {
                if (professionals[p.ID].Contains(p))
                {
                    return true;
                }
                else return false;
             }
            throw new Exception("O registo não existe");
        }

        /// <summary>
        /// The system receives data from a professional, the same data contains the ID of the professional in the system.
        /// The system, based on this ID, checks whether this professional exists in the system.
        /// If so, it checks whether the record that was passed by parameter appears in the system, if found, removes it.
        /// </summary>
        /// <param name="p">Professional</param>
        /// <returns>Returns true if removed, the system professional. Returns false if the professional does not exist in the system</returns>
        public static bool RemoveProfessionalRegist(Professional p)
        {
            if (professionals.ContainsKey(p.ID))
            {
                if (professionals[p.ID].Contains(p))
                {
                    professionals[p.ID].Remove(p);
                    return true;
                }
                return false;
            }
            throw new Exception("O id do registo a remover não existe");

        }


        /// <summary>
        /// Clear dictinary
        /// </summary>
        /// <returns>Return true if sucess</returns>
        public static bool Clear()
        {
            professionals.Clear();
            return true;
        }


        /// <summary>
        /// Copy the entire dictionary
        /// </summary>
        /// <returns>Return the clone of dictionary Professionals </returns>
        public static Dictionary<int, List<Professional>> Clone()
        {
            clonedDictionary = professionals.ToDictionary(entry => entry.Key, entry => entry.Value);
            return clonedDictionary;

        }


        /// <summary>
        /// The function shows the dictionary of professionals
        /// </summary>
        public static bool ShowDictinary()
        {
            Professionals.Clone();
            foreach (KeyValuePair<int, List<Professional>> entry in clonedDictionary)
            {
                Console.WriteLine($"ID: {entry.Key}");

                foreach (Professional professional in entry.Value)
                {
                    Console.WriteLine("" + professional.ToString());

                }

            }
            return true;
        }

        /// <summary>
        /// Stores regists in binary format
        /// </summary>
        /// <param name="fileName">FileName</param>
        /// <returns>Returns true if you can save it.</returns>
        public static bool SaveProfessional(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, professionals);
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
        /// <returns>Returns true if I was able to read from a binary file.</returns>
        public static bool LoadProfessional(string fileName)
        {
            if (File.Exists(fileName) && (new FileInfo(fileName).Length > 0))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    professionals = (Dictionary<int, List<Professional>>)bin.Deserialize(stream);
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
        ~Professionals()
        {
        }
        #endregion

    }


}
