namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class z_ImportService : BaseService<z_Import, Iz_ImportRepository>
    , Iz_ImportService
    {
    private readonly Iz_ImportRepository _z_ImportRepository;
    public z_ImportService(Iz_ImportRepository z_ImportRepository) : base(z_ImportRepository)
    {
    _z_ImportRepository = z_ImportRepository;
    }
    }
    }

