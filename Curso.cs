namespace GerenciamentoEscola
{
    public class Curso
    {
        public string Nome { get; private set; }
        public static string NomeDoCurso { get; private set;}
        public int CodigoDoCurso { get; private set; }
        public static List<Disciplina> ?Disciplinas { get; private set; }
        public static List<Aluno> ?Alunos { get; private set; }

        public Curso(string nome)
        {
            Nome = nome;
            NomeDoCurso = Nome;
            CodigoDoCurso = new Random().Next(9999);
            Disciplinas = new();
            Alunos = new();
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas?.Add(disciplina);
        }

        public static void ListarDisciplinas()
        {
            foreach (Disciplina disciplina in Disciplinas)
            {
                Console.WriteLine($"{disciplina.Titulo}");
            }
        }

        public static void AdicionarAluno(Aluno aluno) => Alunos?.Add(aluno);

        public static void ListarAlunos()
        {
            Console.WriteLine($"Alunos matriculados no curso de {NomeDoCurso}");
            foreach (Aluno aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Nome} {aluno.Sobrenome}");
            }
        }
    }
}
