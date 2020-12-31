using MongoDbGenericRepository.Models;
using System;

namespace MongoRepository.Model
{
	public interface IAppDoc : IDocument<string>
	{
		string Id { get; set; }
		DateTime ComputeDate { get; set; }
	}
}
