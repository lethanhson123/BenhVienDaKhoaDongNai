namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhan_ThuocUngThuService : BaseService<TiepNhan_ThuocUngThu, ITiepNhan_ThuocUngThuRepository>
    , ITiepNhan_ThuocUngThuService
    {
    private readonly ITiepNhan_ThuocUngThuRepository _TiepNhan_ThuocUngThuRepository;
    public TiepNhan_ThuocUngThuService(ITiepNhan_ThuocUngThuRepository TiepNhan_ThuocUngThuRepository) : base(TiepNhan_ThuocUngThuRepository)
    {
    _TiepNhan_ThuocUngThuRepository = TiepNhan_ThuocUngThuRepository;
    }
    }
    }

