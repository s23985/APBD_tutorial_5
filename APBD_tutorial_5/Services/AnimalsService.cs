using APBD_tutorial_5.Models;
using APBD_tutorial_5.Repositories;

namespace APBD_tutorial_5.Services;

public class AnimalsService : IAnimalsService
{
    private IAnimalsRepository _repository;

    public AnimalsService(IAnimalsRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _repository.GetAnimals();
    }

    public Animal? GetAnimal(int idAnimal)
    {
        return _repository.GetAnimal(idAnimal);
    }

    public int CreateAnimal(Animal animal)
    {
        return _repository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _repository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _repository.DeleteAnimal(idAnimal);
    }
}