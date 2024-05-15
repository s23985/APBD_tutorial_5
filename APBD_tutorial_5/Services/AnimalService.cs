using APBD_tutorial_5.Models;
using APBD_tutorial_5.Repositories;

namespace APBD_tutorial_5.Services;

public class AnimalService : IAnimalService
{
    private IAnimalRepository _repository;

    public AnimalService(IAnimalRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _repository.GetAnimals();
    }

    public int CreateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public int UpdateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public int DeleteAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }
}