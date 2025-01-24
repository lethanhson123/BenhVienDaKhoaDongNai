namespace Service_eHospital_DongNai_A.Implement
{
    public class GiayRaVienService : BaseService<GiayRaVien, IGiayRaVienRepository>
    , IGiayRaVienService
    {
    private readonly IGiayRaVienRepository _GiayRaVienRepository;
    public GiayRaVienService(IGiayRaVienRepository GiayRaVienRepository) : base(GiayRaVienRepository)
    {
    _GiayRaVienRepository = GiayRaVienRepository;
    }
    }
    }

