using APBD_tutorial_5.Models;

namespace APBD_tutorial_5.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int idAnimal);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}