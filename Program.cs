using System.Data;
using System.Net;
using GerenciamentoEscola;

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
    public class Program
    {
        public static void Main(string[] args)
        {
            Escola escola = new("Ada tech");

            Curso cSharp = new("C Sharp", escola);
            Curso Java = new("Java", escola);

            Disciplina poo = new("Programação Orientada a Objeto", 10, "Introdução à Programação Orientada a Objetos; Introdução ao Diagrama de Classes da UML; Classes e\r\nMétodos; Encapsulamento e Sobrecarga; Sobreposição de Métodos; Construtores;\r\nHerança; Polimorfismo.");
            Disciplina logica = new("Logica de Programação", 8, "Algoritmos; Análise e construção de algoritmos; Elementos Básicos. (tipos de dados, váriaveis e constantes, comandos, funções)");

            cSharp.AdicionarDisciplina(poo);
            cSharp.AdicionarDisciplina(logica);
            Java.AdicionarDisciplina(poo);
            //Java.AdicionarDisciplina(logica);

            Professor professor1 = new("Otavio", "Miranda", 27, escola);
            Professor professor2 = new("Amanda", "Mantovani", 23, escola);

            Aluno aluno1 = new("Vagner", "Silva", 25, escola);
            Aluno aluno2 = new("Leandro", "Pio", 38, escola);            

            Console.WriteLine("Aluno 1:");
            Console.WriteLine("---------------");
            aluno1.MatricularNoCurso(cSharp);
            aluno1.ListarAluno();
            Console.WriteLine("");
            aluno1.ListarCursosMatriculados();
            Console.WriteLine("");
            aluno1.CargaHorariaDoCurso();
            Console.WriteLine("");

            Console.WriteLine("Aluno 2:");
            Console.WriteLine("---------------");
            aluno2.MatricularNoCurso(Java);
            aluno2.ListarAluno();
            Console.WriteLine("");
            aluno2.ListarCursosMatriculados();
            Console.WriteLine("");
            aluno2.CargaHorariaDoCurso();
            Console.WriteLine("");

            Console.WriteLine("Professor 1:");
            Console.WriteLine("---------------");
            professor1.AtribuirCurso(Java);
            professor1.ListarCursos();
            Console.WriteLine("");
            professor1.AtribuirDisciplina(logica);
            professor1.ListarDisciplinas();
            Console.WriteLine("");
            professor1.ListarProfessor();
            Console.WriteLine("");
            professor1.CargaHorariaDoCurso();
            Console.WriteLine("");

            Console.WriteLine("Professor 2:");
            Console.WriteLine("---------------");
            professor2.AtribuirCurso(cSharp);
            professor2.ListarCursos();
            Console.WriteLine("");
            professor2.AtribuirDisciplina(poo);
            professor2.ListarDisciplinas();
            Console.WriteLine("");
            professor2.ListarProfessor();
            Console.WriteLine("");
            professor2.CargaHorariaDoCurso();
            Console.WriteLine("");

            Console.WriteLine("Escola:");
            escola.ListarCursos();
            Console.WriteLine("");
            escola.ListarProfessores();
            Console.WriteLine("");
            escola.ListarAlunos();
        }
    }
}