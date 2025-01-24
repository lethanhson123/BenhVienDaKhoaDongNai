namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_BenhNhan_GoiDichVuRepository : BaseRepository<CSKH_BenhNhan_GoiDichVu>
    , ICSKH_BenhNhan_GoiDichVuRepository
    {
    private readonly Context _context;
    public CSKH_BenhNhan_GoiDichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

