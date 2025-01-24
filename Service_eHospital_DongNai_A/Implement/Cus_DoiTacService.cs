namespace Service_eHospital_DongNai_A.Implement
{
    public class Cus_DoiTacService : BaseService<Cus_DoiTac, ICus_DoiTacRepository>
    , ICus_DoiTacService
    {
    private readonly ICus_DoiTacRepository _Cus_DoiTacRepository;
    public Cus_DoiTacService(ICus_DoiTacRepository Cus_DoiTacRepository) : base(Cus_DoiTacRepository)
    {
    _Cus_DoiTacRepository = Cus_DoiTacRepository;
    }
    }
    }

