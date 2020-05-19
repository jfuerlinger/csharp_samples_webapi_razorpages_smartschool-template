using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Contracts;
using SmartSchool.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.Web.ApiControllers
{
  /// <summary>
  /// API-Controller für die Abfrage von Messwerten
  /// </summary>
  [Route("api/[controller]")]
  [ApiController]
  public class MeasurementsController : ControllerBase
  {
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Constructor mit DI
    /// </summary>
    /// <param name="unitOfWork"></param>
    public MeasurementsController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Liefert den Messwert per Id und den zugehörigen Sensorinformationen
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Liefert den nächsten Messwert ab einer vorgegebenen Zeit
    /// </summary>
    /// <param name="sensorId"></param>
    /// <param name="date"></param>
    /// <param name="time"></param>
    /// <returns>Messwert oder NotFound, falls es keinen Messwert ab der Zeit gab</returns>
    [HttpGet]
    [Route("measurementat")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetMeasurementForSensorAt(int sensorId, string date, string time)
    {
      throw new NotImplementedException();
    }


    /// <summary>
    /// Fügt für den Sensor mit der Id einen Messwert hinzu
    /// </summary>
    /// <param name="measurementDto"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostMeasurement([FromBody] Object measurementDto) //! DTO verwenden
    {
      // ACHTUNG: measurementDto-Parameter -> DTO verwenden
      throw new NotImplementedException();
    }
  }
}
