namespace GerenciamentoEscola
{
    public class Pessoa
    {
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        protected List<Curso> Cursos { get; set; }
        protected int Idade { get; set; }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cursos = new();
            Idade = idade;
        }

        public virtual void ListarCursos()
        {
            Console.WriteLine($"Lista de Cursos:");
            foreach (Curso curso in Cursos)
            {
                Console.WriteLine($"Nome: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.WriteLine("------------------");
            }
        }
    }
}
