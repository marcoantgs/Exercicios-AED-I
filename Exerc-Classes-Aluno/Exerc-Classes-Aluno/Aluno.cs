using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Classes_Aluno
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool VerificarSePassou()
        {
            if(NotaFinal() >= 60.0)
            {
                return true;
            }
                return false;
        }

        public double NotaRestante()
        {
            if(VerificarSePassou() == false)
            {
                return 60.0 - NotaFinal();
            }
            else
            {
                return 0.0; 
            }
        }
    }
}
