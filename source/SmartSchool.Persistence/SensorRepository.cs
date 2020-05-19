using System;
using System.Linq;
using SmartSchool.Core.Entities;
using SmartSchool.Core.Contracts;

namespace SmartSchool.Persistence
{
    public class SensorRepository : ISensorRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SensorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Liefert eine Liste aller Sensoren sortiert nach dem SensorName
        /// </summary>
        /// <returns></returns>
        public Sensor[] GetAll()
        {
            return _dbContext.Sensors
                .OrderBy(sensor => sensor.Name)
                .ToArray();
        }


    }
}