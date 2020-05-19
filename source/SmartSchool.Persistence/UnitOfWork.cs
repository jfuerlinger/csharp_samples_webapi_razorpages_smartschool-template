using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmartSchool.Core.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SmartSchool.Core.Entities;
using Utils;

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
        }

        /// <summary>
        /// Repository-übergreifendes Speichern der Änderungen
        /// </summary>
        public int SaveChanges()
        {
            var entities = _dbContext.ChangeTracker.Entries()
                .Where(entity => entity.State == EntityState.Added
                                 || entity.State == EntityState.Modified)
                .Select(e => e.Entity);
            foreach (var entity in entities)
            {
                ValidateEntity(entity);
            }

            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
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
        public void DeleteDatabase() => _dbContext.Database.EnsureDeleted();
        public void MigrateDatabase() => _dbContext.Database.Migrate();
    }
}
