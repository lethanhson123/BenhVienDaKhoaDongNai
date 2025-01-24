namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_CSKH_BenhNhan_GoiDichVuChiTietRepository : BaseRepository<His_CSKH_BenhNhan_GoiDichVuChiTiet>
    , IHis_CSKH_BenhNhan_GoiDichVuChiTietRepository
    {
    private readonly Context _context;
    public His_CSKH_BenhNhan_GoiDichVuChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

