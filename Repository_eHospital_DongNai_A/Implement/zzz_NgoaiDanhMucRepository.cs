namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_NgoaiDanhMucRepository : BaseRepository<zzz_NgoaiDanhMuc>
    , Izzz_NgoaiDanhMucRepository
    {
    private readonly Context _context;
    public zzz_NgoaiDanhMucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

