namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnSanKhoa_ChiTietRepository : BaseRepository<BenhAnSanKhoa_ChiTiet>
    , IBenhAnSanKhoa_ChiTietRepository
    {
    private readonly Context _context;
    public BenhAnSanKhoa_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

