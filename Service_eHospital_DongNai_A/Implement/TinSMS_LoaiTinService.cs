namespace Service_eHospital_DongNai_A.Implement
{
    public class TinSMS_LoaiTinService : BaseService<TinSMS_LoaiTin, ITinSMS_LoaiTinRepository>
    , ITinSMS_LoaiTinService
    {
    private readonly ITinSMS_LoaiTinRepository _TinSMS_LoaiTinRepository;
    public TinSMS_LoaiTinService(ITinSMS_LoaiTinRepository TinSMS_LoaiTinRepository) : base(TinSMS_LoaiTinRepository)
    {
    _TinSMS_LoaiTinRepository = TinSMS_LoaiTinRepository;
    }
    }
    }

