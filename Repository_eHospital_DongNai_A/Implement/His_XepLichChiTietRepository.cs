namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_XepLichChiTietRepository : BaseRepository<His_XepLichChiTiet>
    , IHis_XepLichChiTietRepository
    {
    private readonly Context _context;
    public His_XepLichChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

