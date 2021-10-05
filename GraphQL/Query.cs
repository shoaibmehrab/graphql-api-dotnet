using System.Linq;
using CommanderGQL.Database;
using CommanderGQL.Models;
using HotChocolate;

namespace CommanderGQL.GraphQL
{
    public class Query 
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext contex)
        {
            return contex.Platforms;
        }
    }
}