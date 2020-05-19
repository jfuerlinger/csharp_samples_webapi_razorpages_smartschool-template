using System;
using System.Linq;
using SmartSchool.Core.Contracts;
using SmartSchool.Persistence;
using SmartSchool.TestConsole;

namespace SmartSchool.ImportConsole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(">> Import der Measurements und Sensors in die Datenbank");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            using (IUnitOfWork unitOfWorkImport = new UnitOfWork())
            {
                Console.WriteLine("Datenbank löschen");
                unitOfWorkImport.DeleteDatabase();
                Console.WriteLine("Datenbank migrieren");
                unitOfWorkImport.MigrateDatabase();
                Console.WriteLine("Messwerte werden von measurements.csv eingelesen");

                var measurements = ImportController.ReadFromCsv().ToArray();

                if (measurements.Length == 0)
                {
                    Console.WriteLine("!!! Es wurden keine Messwerte eingelesen");
                    return;
                }

                Console.WriteLine(
                    $"  Es wurden {measurements.Count()} Messwerte eingelesen, werden in Datenbank gespeichert ...");
                unitOfWorkImport.MeasurementRepository.AddRange(measurements);
                int countSensors = measurements.GroupBy(m => m.Sensor).Count();
                int savedRows = unitOfWorkImport.SaveChanges();
                Console.WriteLine
                (
                    $"{countSensors} Sensoren und {savedRows - countSensors} Messwerte wurden in Datenbank gespeichert!");
            }

            Console.Write("Beenden mit Eingabetaste ...");
            Console.ReadLine();
        }

    }
}
