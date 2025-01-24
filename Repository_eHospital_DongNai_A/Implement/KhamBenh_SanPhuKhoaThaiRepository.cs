namespace Repository_eHospital_DongNai_A.Implement
{
    public class KhamBenh_SanPhuKhoaThaiRepository : BaseRepository<KhamBenh_SanPhuKhoaThai>
    , IKhamBenh_SanPhuKhoaThaiRepository
    {
    private readonly Context _context;
    public KhamBenh_SanPhuKhoaThaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

