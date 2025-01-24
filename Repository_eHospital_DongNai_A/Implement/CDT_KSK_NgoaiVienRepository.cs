namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_NgoaiVienRepository : BaseRepository<CDT_KSK_NgoaiVien>
    , ICDT_KSK_NgoaiVienRepository
    {
    private readonly Context _context;
    public CDT_KSK_NgoaiVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

