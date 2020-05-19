using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Contracts;
using SmartSchool.Core.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.Persistence
{
  public class MeasurementRepository : IMeasurementRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public MeasurementRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task AddRangeAsync(Measurement[] measurements) =>
      await _dbContext.Measurements
        .AddRangeAsync(measurements);
  }
}