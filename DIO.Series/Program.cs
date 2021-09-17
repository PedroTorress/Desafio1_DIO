using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com uma opção");
            int opc = int.Parse(ConsoleReadline());
            while(opc != 0)
            {
                case 1:
                    ListarSeries();
                    break;
                case 2:
                    InserirSerie();
                    break;
                case 3:
                    AtualizarSerie();
                    break;
                case 4:
                    ExcluirSerie();
                    break;
                case 5:
                    VisualizarSeries();
                    break;
                default:
                    throw new Argument
            }
        }


        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("lista vazia");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaID(), serie.retornaTitulo());
            }
        }

        private static void InserirSerie()
        {
            foreach( int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}",i,Enum.GetValues(typeof(Genero),i));   
            }
            Console.Write("Digite o Genero entre as opções acima: ");
            int entradaGenero = int.Parse(ConsoleReadline());

            Console.Write("Digite o Titulo da serie: ");
            string entradaTitulo = ConsoleReadline();

            Console.Write("Digite o Descrição da serie: ");
            string entradaDescricao = ConsoleReadline();

            Console.Write("Digite o Ano de lançamento da serie: ");
            int entradaAno = int.Parse(ConsoleReadline());

            Serie novaSerie = new Serie(id: repositorio.ProximoID(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,      
                                        descrivao: entradaDescricao); 
        }
    }
}
