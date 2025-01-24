namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamGayMe_NguoiLonService : BaseService<KhamGayMe_NguoiLon, IKhamGayMe_NguoiLonRepository>
    , IKhamGayMe_NguoiLonService
    {
    private readonly IKhamGayMe_NguoiLonRepository _KhamGayMe_NguoiLonRepository;
    public KhamGayMe_NguoiLonService(IKhamGayMe_NguoiLonRepository KhamGayMe_NguoiLonRepository) : base(KhamGayMe_NguoiLonRepository)
    {
    _KhamGayMe_NguoiLonRepository = KhamGayMe_NguoiLonRepository;
    }
    }
    }

