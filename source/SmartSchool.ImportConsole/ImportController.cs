using System;
using System.Collections.Generic;
using System.Linq;
using SmartSchool.Core.Entities;
using Utils;

namespace SmartSchool.TestConsole
{
    public class ImportController
    {
        const string Filename = "measurements.csv";

        /// <summary>
        /// Liefert die Messwerte mit den dazugehörigen Sensoren
        /// </summary>
        public static IEnumerable<Measurement> ReadFromCsv()
        {
            throw new NotImplementedException();
        }

    }
}
