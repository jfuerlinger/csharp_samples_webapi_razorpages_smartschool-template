using System;
using System.Collections.Generic;
using System.Linq;
using SmartSchool.Core.Entities;
using Utils;

namespace SmartSchool.ImportConsole
{
    public class ImportController
    {
        private const string FileName = "measurements.csv";

        /// <summary>
        /// Liefert die Messwerte mit den dazugehörigen Sensoren
        /// </summary>
        public static IEnumerable<Measurement> ReadFromCsv()
        {
            throw new NotImplementedException();
        }
    }
}
