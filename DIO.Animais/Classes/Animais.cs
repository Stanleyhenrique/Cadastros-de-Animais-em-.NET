using System;

namespace DIO.Animais
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private especie Especie { get; set; }
		private string Raca { get; set; }
		private string Peso { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Serie(int id, Especie especie, string raca, string peso, int ano)
		{
			this.Id = id;
			this.Especie = especie;
			this.Raca = raca;
			this.Peso = peso;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
			
            retorno += "Especie: " + this.Especie + Environment.NewLine;
            retorno += "Raça: " + this.Raca + Environment.NewLine;
            retorno += "Peso: " + this.Peso + Environment.NewLine;
            retorno += "Ano que nasceu: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Raca;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}