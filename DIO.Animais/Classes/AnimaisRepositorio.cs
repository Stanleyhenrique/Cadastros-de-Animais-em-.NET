using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class AnimaisRepositorio : IRepositorio<Animais>
	{
        private List<Animais> listaAnimais = new List<Animais>();
		public void Atualiza(int id, Serie objeto)
		{
			listaAnimais[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaAnimais[id].Excluir();
		}

		public void Insere(Animais objeto)
		{
			listaAnimais.Add(objeto);
		}

		public List<Animais> Lista()
		{
			return listaAnimais;
		}

		public int ProximoId()
		{
			return listaAnimais.Count;
		}

		public Animais RetornaPorId(int id)
		{
			return listaAnimais[id];
		}
	}
}