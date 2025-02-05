namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_XepLichTrucService : BaseService<NS_XepLichTruc, INS_XepLichTrucRepository>
    , INS_XepLichTrucService
    {
    private readonly INS_XepLichTrucRepository _NS_XepLichTrucRepository;
    public NS_XepLichTrucService(INS_XepLichTrucRepository NS_XepLichTrucRepository) : base(NS_XepLichTrucRepository)
    {
    _NS_XepLichTrucRepository = NS_XepLichTrucRepository;
    }
    }
    }

