namespace GerenciamentoEscola
{
    public class Curso
    {
        public string Nome { get; private set; }
        public int CodigoDoCurso { get; private set; }
        public List<Disciplina> ?Disciplinas { get; private set; }
        public List<Aluno> ?Alunos { get; private set; }

        public Curso(string nome)
        {
            Nome = nome;
            CodigoDoCurso = new Random().Next(9999);
            Disciplinas = new();
            Alunos = new();
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas?.Add(disciplina);
        }
        public void AdicionarAluno(Aluno aluno) => Alunos?.Add(aluno);
    }
}
