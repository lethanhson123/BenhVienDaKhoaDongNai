namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhan_DoiTuongThayDoiService : BaseService<TiepNhan_DoiTuongThayDoi, ITiepNhan_DoiTuongThayDoiRepository>
    , ITiepNhan_DoiTuongThayDoiService
    {
    private readonly ITiepNhan_DoiTuongThayDoiRepository _TiepNhan_DoiTuongThayDoiRepository;
    public TiepNhan_DoiTuongThayDoiService(ITiepNhan_DoiTuongThayDoiRepository TiepNhan_DoiTuongThayDoiRepository) : base(TiepNhan_DoiTuongThayDoiRepository)
    {
    _TiepNhan_DoiTuongThayDoiRepository = TiepNhan_DoiTuongThayDoiRepository;
    }
    }
    }

