namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachHoiThao_BVThamGiaRepository : BaseRepository<CDT_KeHoachHoiThao_BVThamGia>
    , ICDT_KeHoachHoiThao_BVThamGiaRepository
    {
    private readonly Context _context;
    public CDT_KeHoachHoiThao_BVThamGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

