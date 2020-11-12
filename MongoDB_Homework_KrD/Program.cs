using System;
using MongoDB.Driver;

namespace MongoDB_Homework_KrD
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("PetRegister");
            var repository = new PetRepository(database);

            long count = repository.GetCount();

            if (count == 0)
            {
                repository.InsertPets(PetsList.Pets);
            }

            bool isSelectionShown = true;

            while (isSelectionShown)
            {
                Console.WriteLine("==============");
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1 Show records");
                Console.WriteLine("2 Show report");
                Console.WriteLine("3 Exit");
                Console.Write("==============");

                var key = Console.ReadKey();
                Console.WriteLine();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ShowRecords(repository);
                        break;
                    case ConsoleKey.D2:
                        ShowReport(repository);
                        break;
                    case ConsoleKey.D3:
                        isSelectionShown = false;
                        break;
                }
            }
        }

        private static void ShowRecords(PetRepository repository)
        {
            const int pageSize = 3;
            int pageCount, currentPage = 0;

            do
            {
                Console.WriteLine($"Страница {currentPage + 1}");
                Console.WriteLine();
                var search = repository.Search(currentPage, pageSize);

                foreach (var pet in search)
                {
                    Console.WriteLine("Питомец:");
                    Console.WriteLine($"Кличка = {pet.Nickname}, Вид = {pet.Species}, Дата регистрации = {pet.RegistrationDate}");
                    Console.WriteLine("Хозяин:");
                    Console.WriteLine($"Имя = {pet.Owner.Name}, Телефон = {pet.Owner.Phone}");
                    Console.WriteLine();
                }
                Console.WriteLine();

                currentPage++;
                pageCount = search.Count;
                
            }
            while (pageCount == pageSize);
        }

        private static void ShowReport(PetRepository repository)
        {
            var report = repository.GetReport();

            Console.WriteLine("Отчет по животным:");
            foreach (var record in report)
            {
                Console.WriteLine($"{record.Species} - {record.Count} записей");
            }
        }
    }
}