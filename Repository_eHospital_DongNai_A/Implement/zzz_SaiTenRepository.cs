namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_SaiTenRepository : BaseRepository<zzz_SaiTen>
    , Izzz_SaiTenRepository
    {
    private readonly Context _context;
    public zzz_SaiTenRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

