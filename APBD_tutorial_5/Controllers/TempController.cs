using APBD_tutorial_5.Models;
using APBD_tutorial_5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_tutorial_5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TempController : ControllerBase
{
    private ITempService _tempService;

    public TempController(ITempService tempService)
    {
        _tempService = tempService;
    }

    [HttpPost]
    public IActionResult Create(Person person)
    {
        var affectedCount = _tempService.CreatePerson(person);
        return StatusCode(StatusCodes.Status201Created);
    }
}