using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Contracts;
using SmartSchool.Core.Entities;

namespace SmartSchool.Web.ApiControllers
{
    /// <summary>
    /// API-Controller für die Abfrage von Mitgliedern
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Constructor mit DI
        /// </summary>
        /// <param name="unitOfWork"></param>
        public SensorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Liefert alle Namen der Sensoren
        /// </summary>
        /// <response code="200">Die Abfrage war erfolgreich.</response>
        // GET: api/Categories
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string[]> GetSensorNames()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liefert den Sensor mit der Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetSensor(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Liefert die Sensoren und die Anzahl ihrer Messwerte
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet()]
        [Route("countofmeasurements")]
        public IActionResult GetSensorsWithCountOfMeasurements()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Liefert Sensoren mit den Mittelwerten ihrer Messwerte
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("averagevalues")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetSensorsWithAverageValues()
        {
            throw new NotImplementedException();
        }

    }
}
