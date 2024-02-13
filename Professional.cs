using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoNegocio
{
    #region ENUM

    /// <summary>
    /// List of different professions
    /// </summary>
    public enum JobType
    {
        PHYSICIAN,
        NURSE,
        SECRETARY,
        ASSISTANT,
    };
    #endregion

    /// <summary>
    /// Professional 
    /// </summary>
    [Serializable]
    public class Professional : Person
    {
        #region Atribute

        protected JobType ocupation;

        #endregion

        #region Constructor

    
        /// <summary>
        /// Constructor that recieves atributes as parameters
        /// </summary>
        public Professional(string n, int idade, JobType j)
        {
            id = totPerson;
            name = n;
            age = idade;
            ocupation = j;
          
        }
        #endregion

        #region OtherMethods

        #endregion

        #region Operators

        /// <summary>
        /// Method that redefines the == operator, so that it can be used specifically for the Professional class
        /// </summary>
        /// <param name="p1"> First Professional </param>
        /// <param name="p2">Second professional</param>
        /// <returns> Returns true if the two professionals were the same person. Returns false otherwise</returns>
        public static bool operator == (Professional p1, Professional p2)
        {
            if (p1.age == p2.age && (String.Compare(p1.name, p2.name) == 0) && p1.ocupation == p2.ocupation && p1.id==p2.id) return true;
            return false;

        }

        /// <summary>
        /// Method that redefines the != operator, so that it can be used specifically for the Professional class
        /// </summary>
        /// <param name="p1">First  Professional</param>
        /// <param name="p2">Second  professional</param>
        /// <returns> Returns true if the two professionals are different people. Returns true otherwise</returns>
        public static bool operator != (Professional p1, Professional p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Method that defines the new format of the ToString method for the Professional class
        /// </summary>
        /// <returns>Returns the new format of the ToString method</returns>
        public override string ToString()
        {
            return String.Format("Person: Name: {0} ,Age:{1}, Job:{2}", name, age, ocupation);
        }

        /// <summary>
        /// Definition of the Equals method, for the Professional class
        /// </summary>
        /// <param name="obj"> Professional to be compared</param>
        /// <returns>Returns true if the two professionals were the same person. Returns false otherwise</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Professional aux)
            {
                if (this.ocupation == aux.ocupation && string.Compare(this.name, aux.name) == 0 && this.age == aux.age && this.id==aux.id) return true;
                else
                    return false;
            }
            throw new Exception("O dados que inseriu nao e do tipo Professional");
        }


        #endregion

        #region Properties


        public JobType Ocupacion
        {
            set
            {
                ocupation = value;
            }
            get
            {
                return ocupation;
            }
        }

  
        public int ID
        {
            get
            {
                return id;
            }
        }

        #endregion



    }


    }

