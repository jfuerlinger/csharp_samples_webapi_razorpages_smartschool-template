using System;
using System.Threading.Tasks;
using SmartSchool.Core.Contracts;

namespace SmartSchool.Core.Contracts
{
    public interface IUnitOfWork: IDisposable
    {
 
        IMeasurementRepository MeasurementRepository { get; }
        ISensorRepository SensorRepository { get; }

        int SaveChanges();

        void DeleteDatabase();

        void MigrateDatabase();
    }
}
