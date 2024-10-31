using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_prática
{
    internal class Alunos
    {
        string nome;
        short matricula;
        static double nota1, nota2, notaTrabalho, mediaNotas;

        public void SetNota1(double valor) { nota1 = valor; }
        public void SetNota2(double valor){nota2 = valor;}
        public void SetNotaTrabalho(double valor){notaTrabalho = valor;}

        public double Media(){return (nota1 + nota2) / 2;}
    }
}
