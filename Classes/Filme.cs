namespace DIO.Filmes
{
    public class Filme : EntidadeBase
    {
        

        // Métodos
        public Filme(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluído = false;
            
        }

        public Filme(int id, Genero genero, string? titulo, int ano, string? descricao)
        {
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
			return retorno;
        }

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}

        public void Excluir() 
        {
            this.Excluído = true;
        }
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluído { get; set; }
    }
}