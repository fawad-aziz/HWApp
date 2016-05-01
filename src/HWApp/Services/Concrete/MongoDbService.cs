using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

using HWApp.Models;

namespace HWApp.Services.Concrete
{
	public sealed class MongoDbService
    {
		private readonly IMongoClient client;

		private IMongoDatabase database;

		private MongoDbService()
		{
			const string ConnectionString = "mongodb://localhost:27017";
			this.client = new MongoClient(ConnectionString);
			this.database = this.client.GetDatabase("Activities");
		}

		public static MongoDbService Instance { get; } = new MongoDbService();

		public IMongoClient GetClient()
		{
			return this.client;
		}

		public async Task<IEnumerable<Activity>> GetActivities()
		{
			var activities = this.database.GetCollection<Activity>("Activities");
			var activityQuery = Builders<Activity>.Filter.Where(act => true);
			return await activities.FindAsync(activityQuery).Result.ToListAsync();
		}
    }
}
