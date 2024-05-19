using APBD_tutorial_5.Models;

namespace APBD_tutorial_5.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}