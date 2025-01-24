namespace Service_eHospital_DongNai_A.Implement
{
    public class MienGiamService : BaseService<MienGiam, IMienGiamRepository>
    , IMienGiamService
    {
    private readonly IMienGiamRepository _MienGiamRepository;
    public MienGiamService(IMienGiamRepository MienGiamRepository) : base(MienGiamRepository)
    {
    _MienGiamRepository = MienGiamRepository;
    }
    }
    }

