using System;
using System.Collections.Generic;

namespace TecnicasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }


        private static void ManipularEDBasicas()
        {
            int linha, coluna;
            linha = 3;
            coluna = 3;

            double[] vet1, vet2;

            double[,] mat1 = new double[3, 3];
            double[,] mat2 = new double[3, 3];


            vet1 = new double[3];


            for (int i = 0; i < vet1.Length; i++)
            {
                vet1[i] = 1 + i;
            }

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    mat1[i, j] = 1 + i + j;
                }
            }

            vet2 = vet1;

            vet2[0] = 8;

            mat2 = mat1;

            mat2[0, 0] = 50;
        }

        private static void EfetuarOperacoesDeConjuntos()
        {
            ColecaoHashSet ConjuntosHashSet = new ColecaoHashSet();
            ConjuntosHashSet.AddElementoConjunto();
            //ConjuntosHashSet.DiferencaConjuntoAParaB();
            //ConjuntosHashSet.InterccaoConjuntoAB();
            //ConjuntosHashSet.UniaoConjuntoAB();

        }
    }
}
