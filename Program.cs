namespace GerenciamentoEscola
{
    /*
     * Sistema de Gerenciamento de Escola
        Imagine que você está desenvolvendo um sistema de gerenciamento de escola.
        Crie o cadastro do Aluno com caracteristicas como nome, idade, número de identificação do aluno (matrícula)
        e uma lista de cursos em que o aluno está matriculado. Abra a possibilidade que um aluno se matricule em um curso.
        Crie também uma forma de exibir a lista de cursos em que o aluno está matriculado.
        Crie o cadastro de Curso com caracteristicas como nome, código do curso, os alunos matriculados no curso e as disciplinas deste curso.
        Deve-se permitir que um aluno seja adicionado à lista de alunos do curso, assim como as disciplinas.
        Disponibilize a lista de alunos matriculados no curso. Disponibilize também a lista de disciplinas.
        Crie o cadastro de Disciplinas com caracteristicas como titulo, carga horária e ementa. 
        Crie o cadastro de Professor com o nome, idade e um conjunto de disciplinas que o professor está lecionando.
        Permita que uma disciplina seja atribuída a um professor. Disponibilize a lista de cursos + disciplinas que o professor está lecionando.
        Gerenciar a atribuição de um aluno a um curso e vice-versa onde ambos serão atribuidos um ao outro portanto
        não deve ser possível adicionar um curso a um aluno sem adicionar o aluno ao curso e vice-versa.
        Comece pela criação do UML. Implemente todo o conteúdo aprendido no curso.
        Crie testes na main. Não é necessário criar um menu e sim objetos que acionem todas as classes e métodos criados em uma ordem lógica que faça sentido.

        Adicionar carga horaria total ao curso, somando todas cargas horárias das disciplinas
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new("Vagner", "Silva", 25);
            Aluno aluno2 = new("Leandro", "Pio", 38);
            Professor professor1 = new("Otavio", "Miranda", 27);
            Professor professor2 = new("Amanda", "Mantovani", 23);
            Disciplina poo = new("Programação Orientada a Objeto", 10, "Introdução à Programação Orientada a Objetos; Introdução ao Diagrama de Classes da UML; Classes e\r\nMétodos; Encapsulamento e Sobrecarga; Sobreposição de Métodos; Construtores;\r\nHerança; Polimorfismo.");
            Disciplina logica = new("Logica de Programação", 8, "Algoritmos; Análise e construção de algoritmos; Elementos Básicos. (tipos de dados, váriaveis e constantes, comandos, funções)");
            Curso cSharp = new("C Sharp");
            Curso Java = new("Java");
            cSharp.AdicionarDisciplina(poo);
            Java.AdicionarDisciplina(logica);

            Console.WriteLine("Aluno 1:");
            aluno1.ListarAluno();
            Console.WriteLine("---------------");
            aluno1.MatricularNoCurso(cSharp);
            aluno1.ListarCursos();

            aluno1.ListarAluno();

            Console.WriteLine("Aluno 2:");
            aluno2.ListarAluno();
            Console.WriteLine("---------------");
            aluno2.MatricularNoCurso(Java);
            aluno2.ListarCursos();

            aluno2.ListarAluno();

            Console.WriteLine("Professor 1:");
            professor1.ListarProfessor();
            Console.WriteLine("---------------");
            professor1.AtribuirDisciplina(poo);
            professor1.ListarDisciplinas();

            professor1.AtribuirCurso(cSharp);
            professor1.ListarCursos();

            professor1.ListarProfessor();

            Console.WriteLine("Professor 2:");
            professor2.ListarProfessor();
            Console.WriteLine("---------------");
            professor2.AtribuirDisciplina(logica);
            professor2.ListarDisciplinas();

            professor2.AtribuirCurso(Java);
            professor2.ListarCursos();

            professor2.ListarProfessor();
        }
    }
}