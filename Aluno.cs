namespace GerenciamentoEscola
{
    public class Aluno : Pessoa
    {
        protected int Matricula { get; set; }
        public Aluno(string nome, string sobrenome, int idade, Escola escola) : base(nome, sobrenome, idade)
        {
            Matricula = new Random().Next(9999);
            Cursos = new();
            escola.Alunos.Add(this);
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
            curso.AdicionarAluno(this);
        }
        public void ListarCursosMatriculados()
        {
            Console.WriteLine($"Cursos matriculados:");
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"Nome: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.WriteLine("Disciplina(s) do curso: ");
                foreach (var disciplina in curso.Disciplinas)
                {
                    Console.WriteLine($"{disciplina.Titulo}");
                }
                Console.WriteLine("------------------");
            }
        }

        public void ListarCursos(Escola escola)
        {
            int cursoCount = 1;
            if(escola.Cursos.Count() == 0)
            {
                Console.WriteLine("Nenhum Curso disponivel");
            }
            Console.WriteLine("Cursos disponiveis para matricula:");
            foreach (var curso in escola.Cursos)
            {       
                Console.WriteLine($"[{cursoCount}] {curso.Nome}");
                cursoCount++;
            }
        }
    }
}
