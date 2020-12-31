using Models.Application;
using System;

namespace MongoRepository.Model.AppModel
{
	public class PatientDB : Patient, IAppDoc
	{
		public DateTime ComputeDate { get; set; }
		public int Version { get; set; }
	}
}
