/*authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 27 / 10 / 2023
 * emails: a26418 @alunos.ipca.pt , a26056 @alunos.ipca.pt, a26050 @alunos.ipca.pt
 *
*/


using System;

namespace ObjetoNegocio
{
    /// <summary>
    ///  Class Person
    /// </summary>
    [Serializable]
    public class Person
    {
        #region Attributes

        protected int id;
        protected string name;
        protected int age;
        protected static int totPerson=0;

        #endregion

        #region Methods

        #region Class Constructor
        /// <summary>
        /// Inicialization of TotalProfessional variable 
        /// </summary>
        public Person()
        {
            totPerson++;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie - name
        /// </summary>
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Propertie - age
        /// </summary>
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        #endregion

        #region Other Methods

    

        #endregion

        #endregion
    }
}
