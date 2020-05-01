using System.Threading.Tasks;
using EFGetStarted;
using EFGetStarted.Entidades;
using EFGetStarted.Repositorios;


namespace EFGetStarted.Repositorios{
public interface IUnitOfWork
{
    IGenericRepository<Prueba> GenericRepository { get; }

    void Add(Prueba model);
    void SaveChanges();
}

public class UnitOfWork : IUnitOfWork
{
    
    public UnitOfWork()
    {
        this.context = new ContextoHospital();
    }
    private readonly ContextoHospital context;
 
    private GenericRepository<Prueba> pruebaRepository;
    public GenericRepository<Prueba> PruebaRepository
    {
        get
        {
            if (this.pruebaRepository == null)
            {
                this.pruebaRepository = new GenericRepository<Prueba>(this.context);
            }
            return this.pruebaRepository;
        }
    }

    public IGenericRepository<Prueba> UserRepository => throw new System.NotImplementedException();

    public IGenericRepository<Prueba> GenericRepository => throw new System.NotImplementedException();

    /*
       private GenericRepository<Sale> salesRepository;
       public GenericRepository<Sale> SalesRepository
       {
           get
           {
               if (this.salesRepository == null)
               {
                   this.salesRepository = new GenericRepository<Sale>(this.context);
               }
               return this.salesRepository;
           }
       }*/

    public async Task SaveChangesAsync()
    {
        await this.context.SaveChangesAsync();
    }

    public void Add(Prueba model)
    {
        this.context.Add(model);
    }

    public void SaveChanges()
    {
        this.context.SaveChanges();
    }
}
}