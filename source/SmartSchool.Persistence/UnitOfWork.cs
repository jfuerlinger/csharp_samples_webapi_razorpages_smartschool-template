﻿using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.Core.Entities;

namespace SmartSchool.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationDbContext _dbContext;
    private bool _disposed;

    public UnitOfWork()
    {
      _dbContext = new ApplicationDbContext();
      MeasurementRepository = new MeasurementRepository(_dbContext);
      SensorRepository = new SensorRepository(_dbContext);
    }

    public IMeasurementRepository MeasurementRepository { get; }
    public ISensorRepository SensorRepository { get; }

    private void ValidateEntity(object entity)
    {
      // Validierung der hinterlegten Validierungsattribute
      Validator.ValidateObject(entity, new ValidationContext(entity), true);

      switch (entity)
      {
        case Sensor sensor:
          
          // TODO: Sensor DB-Validierungen durchführen
          
          break;

        default:

          return;
      }
    }

    /// <summary>
    /// Repository-übergreifendes Speichern der Änderungen
    /// </summary>
    public async Task<int> SaveChangesAsync()
    {
      var entities = _dbContext.ChangeTracker.Entries()
          .Where(entity => entity.State == EntityState.Added
                           || entity.State == EntityState.Modified)
          .Select(e => e.Entity);
      foreach (var entity in entities)
      {
        ValidateEntity(entity);
      }

      return await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
      if (!_disposed)
      {
        if (disposing)
        {
          _dbContext.Dispose();
        }
      }
      _disposed = true;
    }
    public async Task DeleteDatabaseAsync() => await _dbContext.Database.EnsureDeletedAsync();
    public async Task MigrateDatabaseAsync() => await _dbContext.Database.MigrateAsync();
  }
}
