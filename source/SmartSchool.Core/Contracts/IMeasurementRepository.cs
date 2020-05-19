using SmartSchool.Core.Entities;
using System;

namespace SmartSchool.Core.Contracts
{
    public interface IMeasurementRepository
    {
        void AddRange(Measurement[] measurements);
    }
}
