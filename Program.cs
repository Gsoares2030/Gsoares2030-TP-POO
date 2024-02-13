/*Program.cs
 * 
 * authors: Ariana Alves, Margarida Rodrigues e Gonçalo Soares
 * date: 7/11/2023
 * emails: a26418@alunos.ipca.pt , a26056@alunos.ipca.pt, a26050@alunos.ipca.pt
 * 
*/

using System;
using ObjetoNegocio;
using BL;
using System.Collections.Generic;
using System.IO;

namespace PL
{
    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            #region Professional

            Console.WriteLine("---------Professional-----------------------------------------------");


            #region Show Professional
            bool r;

            Professional p1 = new Professional("Jose", 23, JobType.NURSE);
            Console.WriteLine("" + p1.ToString());
            #endregion

            #region Insert Professional
            r = GereProfessionals.InsertProfessional(p1);

            if (r == true)
            {
                Console.WriteLine("Inserido com sucesso");
            }
            else
            {
                Console.WriteLine("Falhou");
            }


            Professional p2 = new Professional("Manuel", 24, JobType.PHYSICIAN);
            GereProfessionals.InsertProfessional(p2);

            #endregion

            #region Remove Professional
            r = GereProfessionals.RemoverPofessionalRegist(p2);

            if (r == true)
            {
                Console.WriteLine("Removido com sucesso");
            }
            else
            {
                Console.WriteLine("Falhou");
            }
            #endregion

            #region ExistProfessional
            r = GereProfessionals.ExistsProfessional(p2);

            if (r == true)
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("Não Existe");
            }
            #endregion

            #region Save

            string path1 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\ObjetoNegocio\\";

            r = GereProfessionals.SaveProfessional(path1 + "professionals.txt");

            if (r == true)
                Console.WriteLine("Guardado com sucesso");
            else Console.WriteLine("Erro a guardar");

            #endregion

            #region Show Professionals

            GereProfessionals.ShowProfessionals();

            #endregion

            #region  Clear
            GereProfessionals.Clear();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region HealthProfessional

            Console.WriteLine("---------HealthProfessional------------------------------------------");


            #region Show HealthProfessional
            HealthProfessional h1 = new(60, 22, 36.4, DateTime.Now.AddDays(4));
            HealthProfessional h2 = new(58, 18, 37.1, DateTime.Now.AddDays(3));
            HealthProfessional h3 = new(62, 14, 35.9, DateTime.Now.AddDays(10));
            Console.WriteLine("" + h1.ToString());
            #endregion

            #region Insert HealthProfessional
            GereStress.InsertHealthProfessional(p1.ID, h2);
            GereStress.InsertHealthProfessional(p2.ID, h3);
            GereStress.InsertHealthProfessional(p2.ID, h2);
            r = GereStress.InsertHealthProfessional(p1.ID, h1);

            if (r == true)
            {
                Console.WriteLine("Registada ocorrencia com sucesso");
            }
            else
            {
                Console.WriteLine("Falhou");
            }
           

            #endregion

            #region Remove HealthProfessional
            GereStress.RemoveHealthProfessionalRegist(h1, p1.ID);

            #endregion

            #region Exist HealthProfessional
            r = GereStress.ExistsHealthProfessional(p1.ID, h1);

            if (r == true)
            {
                Console.WriteLine("Existe");
            }
            else
            {
                Console.WriteLine("Não Existe");
            }
            #endregion

            #region Show HealthProfessionals
            GereStress.ShowDictinary();
            #endregion


            #region Save

            string path2 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "\\ObjetoNegocio\\"; 

            r = GereStress.SaveHealthProfessional(path2 + "heathprofessionals.txt");

            if (r == true)
                Console.WriteLine("Guardado com sucesso");
            else Console.WriteLine("Erro a guardar");
            #endregion

            #region Load

            r = GereStress.LoadHealthProfessional(path2 + "heathprofessionals.txt");

            if (r == true)
                Console.WriteLine("Lido com sucesso");
            else Console.WriteLine("Erro na leitura");
            #endregion

          
            #region Clear
            GereStress.Clear();
            #endregion

            Console.WriteLine("--------------------------------------------------------------------");
            #endregion


        }
    }
}
