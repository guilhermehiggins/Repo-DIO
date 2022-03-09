using Series.Enums;

namespace Series.Entities
{
    public class Serie : Entidadebase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano + Environment.NewLine;
            retorno += "Excluido: " + Excluido;
            return retorno;
        }
    }
}
