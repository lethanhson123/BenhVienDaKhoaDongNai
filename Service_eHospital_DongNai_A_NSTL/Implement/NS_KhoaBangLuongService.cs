namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KhoaBangLuongService : BaseService<NS_KhoaBangLuong, INS_KhoaBangLuongRepository>
    , INS_KhoaBangLuongService
    {
    private readonly INS_KhoaBangLuongRepository _NS_KhoaBangLuongRepository;
    public NS_KhoaBangLuongService(INS_KhoaBangLuongRepository NS_KhoaBangLuongRepository) : base(NS_KhoaBangLuongRepository)
    {
    _NS_KhoaBangLuongRepository = NS_KhoaBangLuongRepository;
    }
    }
    }

