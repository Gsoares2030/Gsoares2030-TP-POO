/*ManagementProfessional.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 7/11/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/

using System;

namespace ObjetoNegocio
{
    /// <summary>
    /// Management Professional
    /// </summary>
    [Serializable]
    public class ManagementProfessional
    {
        #region Metodos

        /// <summary>
        /// The method receives the heart and respiratory rate of a professional and checks if the professional is stressed.
        /// </summary>
        /// <param name="fr">Respiratory frequency</param>
        /// <param name="fc">Heart Rate</param>
        /// <returns>Returns 1 if stressed. Returns 0 if it is not stressed</returns>
        public static int AnalyzeData(int fc, int fr, int tempcorp)
        {
            int fc1 = fc;
            int fr1 = fr;
            int tempcomp1 = tempcorp;

            if (fc1 >=95 && fr1 >=20 && tempcomp1>37.9)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        #endregion
    }
}

