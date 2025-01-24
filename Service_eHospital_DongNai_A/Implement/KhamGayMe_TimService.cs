namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_TimService : BaseService<KhamGayMe_Tim, IKhamGayMe_TimRepository>
    , IKhamGayMe_TimService
    {
    private readonly IKhamGayMe_TimRepository _KhamGayMe_TimRepository;
    public KhamGayMe_TimService(IKhamGayMe_TimRepository KhamGayMe_TimRepository) : base(KhamGayMe_TimRepository)
    {
    _KhamGayMe_TimRepository = KhamGayMe_TimRepository;
    }
    }
    }

