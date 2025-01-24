namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_DM_KhoaPhongRepository : BaseRepository<zzz_DM_KhoaPhong>
    , Izzz_DM_KhoaPhongRepository
    {
    private readonly Context _context;
    public zzz_DM_KhoaPhongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

