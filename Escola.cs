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
    }
}
