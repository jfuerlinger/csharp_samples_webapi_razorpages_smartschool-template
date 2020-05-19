using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
    public async Task<Sensor[]> GetAllAsync() =>
      await _dbContext.Sensors
        .OrderBy(sensor => sensor.Name)
        .ToArrayAsync();
    
  }
}