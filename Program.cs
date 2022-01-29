using System;


namespace DIO.Filmes
{
    internal class NewBaseType
    {
        private static void AtualizarFilme()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirFilme()
        {
            throw new NotImplementedException();
        }

        private static void InserirFilme(Filme novoFilme)
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
            Console.Write("Digite o genêro entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do filme: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início do filme: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            Filme filme = new Filme(
                id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);
        }

        private static void ListarFilmes()
        {
            System.Console.WriteLine("Listar filmes");
            
            var lista = repositorio.Lista();

            if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum filme cadastrado.");
				return;
			}

			foreach (var filme in lista)
			{
				Console.WriteLine("#ID {0}: - {1}", filme.retornaId(), filme.retornaTitulo());
			}
        }
        static FilmeRepositorio repositorio = new FilmeRepositorio();

        public static FilmeRepositorio Repositorio { get => repositorio; set => repositorio = value; }

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
                NewMethod(opcaoUsuario);
        }

        private static void NewMethod(string opcaoUsuario)
        {
            Filme filme = null;
            switch (opcaoUsuario)
            {
                case "1":
                    ListarFilmes();
                    break;
                case "2":
                    InserirFilme(filme);
                    break;
                case "3":
                    AtualizarFilme();
                    break;
                case "4":
                    ExcluirFilme();
                    break;
                case "5":
                    VisualizarFilme();
                    break;
                case "C":
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar filme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine(); 

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void VisualizarFilme()
        {
            throw new NotImplementedException();
        }
    }
}
    
