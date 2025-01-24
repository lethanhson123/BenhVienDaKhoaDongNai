namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_BS_YLenh_BRepository : BaseRepository<zzz_BS_YLenh_B>
    , Izzz_BS_YLenh_BRepository
    {
    private readonly Context _context;
    public zzz_BS_YLenh_BRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

