namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_TreEmService : BaseService<KhamGayMe_TreEm, IKhamGayMe_TreEmRepository>
    , IKhamGayMe_TreEmService
    {
    private readonly IKhamGayMe_TreEmRepository _KhamGayMe_TreEmRepository;
    public KhamGayMe_TreEmService(IKhamGayMe_TreEmRepository KhamGayMe_TreEmRepository) : base(KhamGayMe_TreEmRepository)
    {
    _KhamGayMe_TreEmRepository = KhamGayMe_TreEmRepository;
    }
    }
    }

