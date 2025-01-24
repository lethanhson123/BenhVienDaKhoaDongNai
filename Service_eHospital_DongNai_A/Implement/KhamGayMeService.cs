namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamGayMeService : BaseService<KhamGayMe, IKhamGayMeRepository>
    , IKhamGayMeService
    {
    private readonly IKhamGayMeRepository _KhamGayMeRepository;
    public KhamGayMeService(IKhamGayMeRepository KhamGayMeRepository) : base(KhamGayMeRepository)
    {
    _KhamGayMeRepository = KhamGayMeRepository;
    }
    }
    }

