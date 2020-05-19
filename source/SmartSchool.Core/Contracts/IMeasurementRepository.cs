using SmartSchool.Core.Entities;
using System;
using System.Threading.Tasks;

namespace SmartSchool.Core.Contracts
{
  public interface IMeasurementRepository
  {
    Task AddRangeAsync(Measurement[] measurements);
  }
}
