namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_CLSYeuCauRepository : BaseRepository<zzz_CLSYeuCau>
    , Izzz_CLSYeuCauRepository
    {
    private readonly Context _context;
    public zzz_CLSYeuCauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

