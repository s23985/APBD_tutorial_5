using APBD_tutorial_5.Models;
using APBD_tutorial_5.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_tutorial_5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private IAnimalsService _service;

    public AnimalsController(IAnimalsService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public IActionResult GetAnimals([FromQuery] string orderBy)
    {
        var animals = _service.GetAnimals();

        animals = orderBy switch
        {
            "description" => animals.OrderBy(x => x.Description),
            "category" => animals.OrderBy(x => x.Category),
            "area" => animals.OrderBy(x => x.Area),
            _ => animals.OrderBy(x => x.Name)
        };
        
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _service.CreateAnimal(animal);
        return CreatedAtAction(nameof(GetAnimals), new { id = animal.IdAnimal }, animal);
    }
    
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        if (id != animal.IdAnimal)
            return BadRequest();

        if (AnimalExists(id) == false)
            return NotFound();
        
        _service.UpdateAnimal(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        if (AnimalExists(id) == false)
            NotFound();
        
        _service.DeleteAnimal(id);
        return NoContent();
    }
    
    private bool AnimalExists(int id)
    {
        return _service.GetAnimal(id) != null;
    }
}