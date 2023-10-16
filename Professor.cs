namespace GerenciamentoEscola
{
    public class Professor : Pessoa
    {
        protected List<Disciplina> Disciplinas { get; set; }
        protected int Id { get; set; }
        public Professor(string nome, string sobrenome, int idade) : base(nome, sobrenome, idade)
        {
            Id = new Random().Next(9999);
            Disciplinas = new();
            Cursos = new();
        }

        public void ListarProfessor()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sobrenome: {Sobrenome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"ID: {Id}");
            if (Cursos.Count() == 0)
            {
                Console.WriteLine("Professor não está lecionando nenhum Curso");
            }
            else
            {
                ListarCursos();
            }
            if (Disciplinas.Count() == 0)
            {
                Console.WriteLine("Professor não está lecionando nenhuma Disciplina");
            }
            else
            {
                ListarDisciplinas();
            }
        }

        public void AtribuirDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
        public void AtribuirCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public void ListarDisciplinas()
        {
            Console.WriteLine($"Disciplinas atribuidas:");
            foreach (Disciplina disciplina in Disciplinas)
            {                
                Console.WriteLine($"Titulo: {disciplina.Titulo}");
                Console.WriteLine($"Carga horaria: {disciplina.CargaHoraria}");
                Console.WriteLine($"Ementa: {disciplina.Ementa}");
                Console.WriteLine("------------------");
            }
        }

        public override void ListarCursos()
        {
            Console.WriteLine($"Cursos atribuidos:");
            foreach (Curso curso in Cursos)
            {
                Console.WriteLine($"Nome: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.Write("Disciplina(s) lecionada(s): "); Curso.ListarDisciplinas();
                Curso.ListarAlunos();
                Console.WriteLine("------------------");
            }
        }
    }
}
