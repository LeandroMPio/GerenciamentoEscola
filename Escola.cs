namespace GerenciamentoEscola
{
    public class Escola
    {
        public string Nome { get; private set; }
        public List<Curso> Cursos { get; private set; }
        public List<Professor> Professores { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public Escola(string nome)
        {
            Nome = nome;
            Cursos = new();
            Professores = new();
            Alunos = new();
        }

        public void ListarCursos()
        {
            Console.WriteLine($"Cursos disponíveis na Escola {Nome}");
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"Nome do curso: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.WriteLine("Disciplina(s):");
                foreach (var disciplina in curso.Disciplinas)
                {
                    Console.WriteLine($"{disciplina.Titulo}");
                }
                Console.WriteLine("");
            }
        }
        public void ListarProfessores()
        {
            Console.WriteLine($"Corpo docente da Escola {Nome}");
            foreach (var professor in Professores)
            {
                Console.WriteLine($"Nome: {professor.Nome}");
                Console.WriteLine($"Sobrenome: {professor.Sobrenome}");
                Console.WriteLine($"Idade: {professor.Idade}");
                Console.WriteLine("");
            }
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos da Escola {Nome}");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Sobrenome: {aluno.Sobrenome}");
                Console.WriteLine($"Idade: {aluno.Idade}");
                Console.WriteLine("");
            }
        }
    }
}
