/*UnitTest.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 17/11/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjetoNegocio;
using BL;
using System;

namespace TestHealthProfessional
{
    /// <summary>
    /// Unit Test one 
    /// </summary>
    [TestClass]
    public class UnitTestHeathProfessional
    {
        [TestMethod]
        public void TestMethod1()
        {
            Professional p1 = new Professional("Joaquim", 23, JobType.SECRETARY);
            HealthProfessional h1 = new HealthProfessional(15, 12, 32, DateTime.Now.AddDays(3));

            bool aux = GereStress.InsertHealthProfessional(p1.ID, h1);

            Assert.IsTrue(aux == true, "Os valores do registo não são valido");


        }

        /// <summary>
        /// Unit Test two
        /// </summary>
        [TestMethod]
        public void TestMethd2()
        {
            HealthProfessional h2 = new HealthProfessional(50, 23, 38, DateTime.Now.AddDays(3));

            bool aux2 = GereStress.RemoveHealthProfessionalRegist(h2, 7);

            Assert.IsTrue(aux2 ==true , "O id colocado não é valido");
        }
    }
}