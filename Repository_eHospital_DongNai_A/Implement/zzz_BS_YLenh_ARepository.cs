namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_BS_YLenh_ARepository : BaseRepository<zzz_BS_YLenh_A>
    , Izzz_BS_YLenh_ARepository
    {
    private readonly Context _context;
    public zzz_BS_YLenh_ARepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

