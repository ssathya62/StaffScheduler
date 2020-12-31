using MongoDbGenericRepository;
using System;

namespace MongoRepository.Repository
{
	public class Repository<TKey> : BaseMongoRepository<TKey>, IAppRepository<TKey> where TKey : IEquatable<TKey>
	{

		#region Public Constructors

		public Repository(string connectionString, string databaseName = null) : base(connectionString, databaseName)
		{
		}

		#endregion Public Constructors


		#region Public Methods

		public void DropCollection<TDocument>()
		{
			MongoDbContext.DropCollection<TDocument>();
		}

		#endregion Public Methods
	}
}