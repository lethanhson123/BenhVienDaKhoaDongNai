namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_BenhNhan_GoiDichVuChiTietRepository : BaseRepository<CSKH_BenhNhan_GoiDichVuChiTiet>
    , ICSKH_BenhNhan_GoiDichVuChiTietRepository
    {
    private readonly Context _context;
    public CSKH_BenhNhan_GoiDichVuChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

