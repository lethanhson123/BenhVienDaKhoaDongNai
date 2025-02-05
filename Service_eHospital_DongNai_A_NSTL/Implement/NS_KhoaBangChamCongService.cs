namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KhoaBangChamCongService : BaseService<NS_KhoaBangChamCong, INS_KhoaBangChamCongRepository>
    , INS_KhoaBangChamCongService
    {
    private readonly INS_KhoaBangChamCongRepository _NS_KhoaBangChamCongRepository;
    public NS_KhoaBangChamCongService(INS_KhoaBangChamCongRepository NS_KhoaBangChamCongRepository) : base(NS_KhoaBangChamCongRepository)
    {
    _NS_KhoaBangChamCongRepository = NS_KhoaBangChamCongRepository;
    }
    }
    }

