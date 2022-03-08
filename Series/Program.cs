
using Series.Classes;

namespace Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string option = UserOption();
            while(option.ToUpper() != "X")
            {
                switch (option)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break ;
                    case "4":
                        RemoveSerie();
                        break;
                    case "5":
                        ShowSerie();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                option = UserOption();
            }
            Console.WriteLine();
            Console.WriteLine("É uma pena que esteja saindo, obrigado por usar nosso serviço");
        }

        private static void ListSeries()
        {
            var list = repository.List();
            if(list.Count == 0)
            {
                Console.WriteLine("Sem series cadastradas");
                return;
            }
            foreach (var serie in list)
            {
                var isremoved = serie.returningRemoved();
                if (!isremoved)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.returnId(), serie.returnTitle());
                }
                
            }

        }
        private static void InsertSerie()
        {
            foreach (int item in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine("{0} - {1}", item , Enum.GetName(typeof(Type), item));
            }
            Console.WriteLine();
            Console.WriteLine("Digite um genero entre as opções acima");
            int TypeOption = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o Titulo da Serie");
            string TitleOption = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o ano que a serie foi criada");
            int YearOption = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a descrição da serie");
            string DescriptionOption = Console.ReadLine();
            Console.WriteLine();

            Serie newSerie = new Serie(id: repository.NextId(), type: (Type)TypeOption, title: TitleOption, year: YearOption, description: DescriptionOption);
            repository.Insert(newSerie);
        }
        private static void UpdateSerie()
        {
            Console.WriteLine("Digite o ID da Serie");
            int indexserie = int.Parse(Console.ReadLine());
            foreach (int item in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Type), item));
            }
            Console.WriteLine();
            Console.WriteLine("Digite um genero entre as opções acima");
            int TypeOption = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o Titulo da Serie");
            string TitleOption = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o ano que a serie foi criada");
            int YearOption = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a descrição da serie");
            string DescriptionOption = Console.ReadLine();
            Console.WriteLine();
            Serie updateSerie = new Serie(id: indexserie, type: (Type)TypeOption, title: TitleOption, year: YearOption, description: DescriptionOption);
            repository.Update(indexserie, updateSerie);
        }
        private static void RemoveSerie()
        {
            Console.WriteLine("Digite o ID da Serie");
            int indexserie = int.Parse(Console.ReadLine());
            repository.Delete(indexserie);
        }
        private static void ShowSerie()
        {
            Console.WriteLine("Digite o ID da Serie");
            int indexserie = int.Parse(Console.ReadLine());
            var serie = repository.ReturnForId(indexserie);
            Console.WriteLine(serie);
        }
        private static string UserOption()
        {
            Console.WriteLine();
            Console.WriteLine(" Informe a opção desejada");
            Console.WriteLine();
            Console.WriteLine(" 1 - Listar series");
            Console.WriteLine(" 2 - Inserir nova serie");
            Console.WriteLine(" 3 - Atualizar serie");
            Console.WriteLine(" 4 - Excluir serie");
            Console.WriteLine(" 5 - Visualizar serie");
            Console.WriteLine(" X - Sair ");
            Console.WriteLine();
            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}


