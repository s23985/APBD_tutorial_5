using APBD_tutorial_5.Models;
using APBD_tutorial_5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_tutorial_5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _service;

    public AnimalController(IAnimalService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _service.GetAnimals();
        return Ok(animals);
    }
    
    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        var affectedCount = _service.UpdateAnimal(animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var affectedCount = _service.DeleteAnimal(id);
        return NoContent();
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _service.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
}