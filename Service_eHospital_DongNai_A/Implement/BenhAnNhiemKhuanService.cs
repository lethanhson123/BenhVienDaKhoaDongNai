namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnNhiemKhuanService : BaseService<BenhAnNhiemKhuan, IBenhAnNhiemKhuanRepository>
    , IBenhAnNhiemKhuanService
    {
    private readonly IBenhAnNhiemKhuanRepository _BenhAnNhiemKhuanRepository;
    public BenhAnNhiemKhuanService(IBenhAnNhiemKhuanRepository BenhAnNhiemKhuanRepository) : base(BenhAnNhiemKhuanRepository)
    {
    _BenhAnNhiemKhuanRepository = BenhAnNhiemKhuanRepository;
    }
    }
    }

