namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachHoiThao_CBThamGiaRepository : BaseRepository<CDT_KeHoachHoiThao_CBThamGia>
    , ICDT_KeHoachHoiThao_CBThamGiaRepository
    {
    private readonly Context _context;
    public CDT_KeHoachHoiThao_CBThamGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

