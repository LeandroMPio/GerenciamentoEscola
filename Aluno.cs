namespace GerenciamentoEscola
{
    public class Aluno : Pessoa
    {
        protected int Matricula { get; set; }

        public Aluno(string nome, string sobrenome, int idade) : base(nome, sobrenome, idade)
        {
            Matricula = new Random().Next(9999);
            Cursos = new();
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sobrenome: {Sobrenome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matricula {Matricula}");
            if (Cursos.Count() == 0)
            {
                Console.WriteLine("Aluno não está matriculado em nenhum Curso");
            }
            else
            {
            ListarCursos();
            }
        }

        public void MatricularNoCurso(Curso curso)
        {
            Cursos.Add(curso);
            Curso.AdicionarAluno(this);
        }

        public override void ListarCursos()
        {
            Console.WriteLine($"Cursos matriculados:");
            foreach (Curso curso in Cursos)
            {
                Console.WriteLine($"Nome: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.Write("Disciplina(s) do curso: "); Curso.ListarDisciplinas();
                Console.WriteLine("------------------");
            }
        }
    }
}
