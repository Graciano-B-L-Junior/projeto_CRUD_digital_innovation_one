using System;

namespace projeto1_Dio
{
    class Program
    {
        static SeriesInterface repositorio = new SeriesInterface();
        static void Main(string[] args)
        {
            string opcaoSelecionada = obterResultado();

            while (opcaoSelecionada != "X")
            {
                switch (opcaoSelecionada)
                {
                    case "1":
                        ListarSeries();
                        opcaoSelecionada = obterResultado();
                        break;
                    case "2":
                        InserirSerie();
                        opcaoSelecionada = obterResultado();
                        break;
                    case "3":
                        //AtualizarSerie();
                        break;
                    case "4":
                        //ExluirSerie();
                        break;
                    case "5":
                        //VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            Console.WriteLine("Hello World!");
        }

        public static void ListarSeries()
        {
            Console.WriteLine("Listar Series");

            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie encontrada");
                return;
            }
            foreach (var l in lista)
            {
                Console.WriteLine($"ID {l.Id} - {l.returnTitulo()}");
            }
        }

        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova serie");
            int indice = 1;
            foreach (var i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{Enum.GetName(typeof(Genero), i)} - {indice}");
                indice++;
            }

            Console.WriteLine("Digite entre um dos valores acima");

            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o ano da Serie");

            int AnoSerie = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escreva o titulo da série");

            string tituloSerie = Console.ReadLine();
            Console.WriteLine("Digite a descrição da série");

            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(repositorio.proximoId(),(Genero)entradaGenero,tituloSerie,entradaDescricao,AnoSerie);
            
            repositorio.insere(novaSerie);
        }

        public static string obterResultado()
        {
            Console.WriteLine();
            Console.WriteLine("DIO series ao seu dispor");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Exluir série");
            Console.WriteLine("5- Vizualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
