using MongoDbGenericRepository.Models;
using System;

namespace MongoRepository.Model
{
	public interface IAppDoc : IDocument<string>
	{		
		DateTime ComputeDate { get; set; }
	}
}
