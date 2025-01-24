namespace Service_eHospital_DongNai_A.Implement
{
    public class ChandoanService : BaseService<Chandoan, IChandoanRepository>
    , IChandoanService
    {
    private readonly IChandoanRepository _ChandoanRepository;
    public ChandoanService(IChandoanRepository ChandoanRepository) : base(ChandoanRepository)
    {
    _ChandoanRepository = ChandoanRepository;
    }
    }
    }

