using System;

namespace DIO.Animais
{
    class Program
    {
        static AnimaisRepositorio repositorio = new AnimaisRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarAnimais();
						break;
					case "2":
						InserirAnimais();
						break;
					case "3":
						AtualizaAnimais();
						break;
					case "4":
						ExcluirAnimais();
						break;
					case "5":
						VisualizarAnimais();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços! <3");
			Console.ReadLine();
        }

        private static void ExcluirAnimais()
		{
			Console.Write("Digite o id do animal: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarAnimais()
		{
			Console.Write("Digite o id do animal: ");
			int indiceAnimais = int.Parse(Console.ReadLine());

			var Animais = repositorio.RetornaPorId(indiceAnimais);

			Console.WriteLine(Animais);
		}

        private static void AtualizarAnimais()
		{
			Console.Write("Digite o id da Animal: ");
			int indiceAnimais = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Especie)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Especie), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaEspecie = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaRaça = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaPeso = Console.ReadLine();

			Serie atualizaAnimais = new Serie(id: indiceAnimais,
										especie: (Especie)entradaEspecie,
										raca: entradaRaca,
										ano: entradaAno,
										peso: entradaPeso);

			repositorio.Atualiza(indiceAnimais, atualizaAnimais);
		}
        private static void ListarAnimais()
		{
			Console.WriteLine("Listar Animais");

			var lista = repositorio.Animais();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma animal cadastrado. :(");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = Animais.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaRaca(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir novo animal");

			
			foreach (int i in Enum.GetValues(typeof(Especie)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Especie), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaEspecie = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaRaca = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaPeso = Console.ReadLine();

			Animal novaAnimal = new Animal(id: repositorio.ProximoId(),
										especie: (Especie)entradaEspecie,
										raca: entradaRaca,
										ano: entradaAno,
										peso: entradaPeso);

			repositorio.Insere(novaAnimal);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Animais a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar Animais");
			Console.WriteLine("2- Inserir novo Animal");
			Console.WriteLine("3- Atualizar Animais");
			Console.WriteLine("4- Excluir Animais");
			Console.WriteLine("5- Visualizar Animais");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
