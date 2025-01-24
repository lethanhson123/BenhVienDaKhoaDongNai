namespace Service_eHospital_DongNai_A.Implement
{
    public class DongNai_AService : BaseService<DongNai_A, IDongNai_ARepository>
    , IDongNai_AService
    {
    private readonly IDongNai_ARepository _DongNai_ARepository;
    public DongNai_AService(IDongNai_ARepository DongNai_ARepository) : base(DongNai_ARepository)
    {
    _DongNai_ARepository = DongNai_ARepository;
    }
    }
    }

