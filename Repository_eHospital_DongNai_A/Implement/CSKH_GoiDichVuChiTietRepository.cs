namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_GoiDichVuChiTietRepository : BaseRepository<CSKH_GoiDichVuChiTiet>
    , ICSKH_GoiDichVuChiTietRepository
    {
    private readonly Context _context;
    public CSKH_GoiDichVuChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

