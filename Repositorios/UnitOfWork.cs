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
        this.repositorio = new GenericRepository<Prueba>(this.context);
    }
    private readonly ContextoHospital context;
 
    private GenericRepository<Prueba> repositorio;
    public IGenericRepository<Prueba> GenericRepository
    {
        get
        {
            if (this.repositorio == null)
            {
                this.repositorio = new GenericRepository<Prueba>(this.context);
            }
            return this.repositorio;
        }
    }
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

       /* public async Task SaveChangesAsync()
    {
        await this.context.SaveChangesAsync();
    }*/

    public void Add(Prueba model)
    {
        this.repositorio.Add(model);
    }

    public void SaveChanges()
    {
        this.context.SaveChanges();
    }
}
}