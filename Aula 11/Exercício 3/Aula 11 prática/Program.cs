namespace Aula_11_prática
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();

            aluno.SetNota1(12.5);
            aluno.SetNota2(7.0);
            aluno.SetNotaTrabalho(9.0);

            Console.WriteLine("A media de notas das provas é: " + aluno.Media());
        }
    }
}
