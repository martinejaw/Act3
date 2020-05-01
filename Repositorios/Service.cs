using System.Collections.Generic;
using EFGetStarted.Entidades;

namespace EFGetStarted.Repositorios{
public interface IPruebaService
{
    IEnumerable<Prueba> GetAll();
    void Create(Prueba model);
}

public class PruebaService : IPruebaService
{
    private readonly IUnitOfWork _uow;

    public PruebaService(
        IUnitOfWork unitOfWork
    )
    {
        _uow = unitOfWork;
    }

    public void Create(Prueba model)
    {
        // Call to your repository
        _uow.GenericRepository.Add(model);

        // Save changes
        _uow.SaveChanges();
    }

    public IEnumerable<Prueba> GetAll()
    {
        return _uow.GenericRepository.GetAll();
    }
}
}