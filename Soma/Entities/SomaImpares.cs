using System;

namespace Soma.Calculo
{
    class SomaImpares
    {
        public int Numero1 { get; private set; }
        public int Numero2 { get; private set; }
        public int Soma { get; private set; }
        public SomaImpares(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }
        public int SomaDeImpares()
        {
            if (Numero1 < Numero2)
            {
                for (int i = Numero1 + 1; i <= Numero2; i++)
                {
                    if (i % 2 != 0)
                    {
                        Soma = i;
                    }
                }
            }
            else
            {
                for (int i = Numero2 + 1; i < Numero1; i++)
                {
                    if (i % 2 != 0)
                    {
                        Soma += i;
                    }
                }
            }
            return Soma;
        }
    }
}
