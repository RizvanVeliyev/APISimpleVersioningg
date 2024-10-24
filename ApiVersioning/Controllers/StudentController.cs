using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers;

[ApiVersion("1.0")]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[Controller]")]
[ApiController]
public class StudentController:ControllerBase
{
    [MapToApiVersion("1.0")]
    [HttpGet("GetStudents")]
    public IActionResult GetV1()
    {
        return Ok("V1 will be implemented");
    }
    [MapToApiVersion("2.0")]
    [HttpGet("GetStudents")]
    public IActionResult GetV2()
    {
        return Ok("V2 will be implemented");
    }
    [HttpPost]
    public IActionResult Create(Student student)
    {
        return Created("Student",student);
    }
}
