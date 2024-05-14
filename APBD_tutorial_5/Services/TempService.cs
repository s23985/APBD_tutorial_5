using APBD_tutorial_5.Models;
using APBD_tutorial_5.Repositories;

namespace APBD_tutorial_5.Services;

public class TempService : ITempService
{
    private ITempRepo _tempRepo;

    public TempService(ITempRepo tempRepo)
    {
        _tempRepo = tempRepo;
    }

    public int CreatePerson(Person person)
    {
        return _tempRepo.Create(person);
    }
}