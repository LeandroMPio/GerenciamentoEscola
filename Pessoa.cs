namespace GerenciamentoEscola
{
    public class Pessoa
    {
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        protected List<Curso> Cursos { get; set; }
        protected int Idade { get; set; }

        public Pessoa()
        {

        }
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
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"Nome: {curso.Nome}");
                Console.WriteLine($"Código do curso: {curso.CodigoDoCurso}");
                Console.WriteLine("------------------");
            }
        }
        public void CargaHorariaDoCurso()
        {
            foreach (var curso in Cursos)
            {
                int CargaHorariatotal = curso.Disciplinas.Sum(x => x.CargaHoraria);
                Console.WriteLine($"Carga horária do Curso é de {CargaHorariatotal} horas");

            }
        }
    }
}
