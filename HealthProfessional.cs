/*HealthProfessionals.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 7/11/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/
using System;
using System.IO;
using System.Text;



namespace ObjetoNegocio
{
    /// <summary>
    /// Health Professional
    /// </summary>
    [Serializable]
    public class HealthProfessional
    {
        #region Atributes


        [NonSerialized]
        private int fc;
        private int fr;
        private double temcorp; /* Temperatura Corporal*/
        private DateTime data;


        #endregion
        #region Methods

        #region Constructor
    
        /// <summary>
        /// Constructor that recieves atributes as parameters
        /// </summary>
        public HealthProfessional(int fc,int fr, double temperatura, DateTime data)
        {
            this.fr = fr;
            this.fc = fc;
            temcorp = temperatura;
            this.data = data;
        }
        #endregion

        #region OtherMethods
 
        #endregion

        #region Operators

        /// <summary>
        /// Method that redefines the == operator, so that it can be used specifically for the Healthcare Professional class
        /// </summary>
        /// <param name="p1"> First Healthcare Professional </param>
        /// <param name="p2">Second health professional</param>
        /// <returns> Returns true if the two health professionals were the same person. Returns false otherwise</returns>
        public static bool operator ==(HealthProfessional p1, HealthProfessional p2)
        {
            if ((p1.fc == p2.fc) && (p1.data==p2.data) && (p1.fr==p2.fr) && (p1.temcorp==p2.temcorp))return true;
            return false;

        }

        /// <summary>
        /// Method that redefines the != operator, so that it can be used specifically for the Healthcare Professional class
        /// </summary>
        /// <param name="p1">First Healthcare Professional</param>
        /// <param name="p2">Second health professional</param>
        /// <returns> Returns true if the two healthcare professionals are different people. Returns true otherwise</returns>
        public static bool operator !=(HealthProfessional p1, HealthProfessional p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Method that defines the new format of the ToString method for the Health Professional class
        /// </summary>
        /// <returns>Returns the new format of the ToString method</returns>
        public override string ToString()
        {
            return String.Format("HealthProfessional: FC: {0} ,FR:{1}, Tempcorp:{2}, Data: {3}", fc, fr, temcorp, data);
        }

        /// <summary>
        /// Definition of the Equals method, for the Health professional class
        /// </summary>
        /// <param name="obj">Health professional to be compared</param>
        /// <returns>Returns true if the two health professionals were the same person. Returns false otherwise</returns>
        public override bool Equals(object? obj)
        {
            if (obj is HealthProfessional aux)
            {
                if (this.data==aux.data && this.fr == aux.fr && this.fc==aux.fc && this.temcorp==aux.temcorp) return true;
                else
                    return false;
            }
            throw new Exception("O dados que inseriu nao e do tipo HealthProfessional" );
        }

       
        #endregion

        #region Properties

      
        public int FR
        {
            set
            {
                fr = value;
                
            }
            get
            {
                return fr;
            }
        }

    
        public int FC
        {
            set
            {
                fc = value;

            }
            get
            {
                return fc;
            }
        }

        public double TemCorp
        {
            set
            {
                temcorp = value;

            }
            get
            {
                return temcorp;
            }
        }

        

        #endregion


        #endregion
    }
}

