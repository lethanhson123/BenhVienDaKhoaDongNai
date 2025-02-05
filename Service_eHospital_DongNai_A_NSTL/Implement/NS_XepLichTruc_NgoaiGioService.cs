namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_XepLichTruc_NgoaiGioService : BaseService<NS_XepLichTruc_NgoaiGio, INS_XepLichTruc_NgoaiGioRepository>
    , INS_XepLichTruc_NgoaiGioService
    {
    private readonly INS_XepLichTruc_NgoaiGioRepository _NS_XepLichTruc_NgoaiGioRepository;
    public NS_XepLichTruc_NgoaiGioService(INS_XepLichTruc_NgoaiGioRepository NS_XepLichTruc_NgoaiGioRepository) : base(NS_XepLichTruc_NgoaiGioRepository)
    {
    _NS_XepLichTruc_NgoaiGioRepository = NS_XepLichTruc_NgoaiGioRepository;
    }
    }
    }

