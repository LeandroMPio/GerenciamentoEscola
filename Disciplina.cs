using System.Drawing;

namespace GerenciamentoEscola
{
    public class Disciplina
    {
        public string Titulo { get; private set; }
        public int CargaHoraria { get; private set; }
        public string Ementa { get; private set; }

        public Disciplina(string titulo, int cargaHoraria, string ementa)
        {
            Titulo = titulo;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }        
    }
}
