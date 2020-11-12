using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;

namespace MongoDB_Homework_KrD
{
    public class PetRepository
    {
        protected readonly IMongoCollection<Pet> collection;

        public PetRepository(IMongoDatabase database)
        {
            collection = database.GetCollection<Pet>(nameof(Pet));

            collection.Indexes.CreateMany(new[]
            {
                new CreateIndexModel<Pet>($"{{ {nameof(Pet.RegistrationDate)}: 1 }}"),
                new CreateIndexModel<Pet>($"{{ {nameof(Pet.Species)}: 2 }}")
            });
        }

        public long GetCount()
        {
            return collection.EstimatedDocumentCount();
        }

        public void InsertPets(IEnumerable<Pet> pets)
        {
            collection.InsertMany(pets);
        }

        public List<Pet> Search(int pageNumber, int pageSize)
        {
            return collection.Find(Builders<Pet>.Filter.Empty)
                .Sort(Builders<Pet>.Sort.Descending(p => p.RegistrationDate))
                .Skip(pageSize * pageNumber)
                .Limit(pageSize)
                .ToList();
        }

        public List<Report> GetReport()
        {
            return collection.Aggregate(new AggregateOptions { AllowDiskUse = true })
                .Group(p => p.Species, g => new Report { Species = g.Key, Count = g.Count() })
                .ToList();
        }
    }
}

