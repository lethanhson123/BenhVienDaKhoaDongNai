namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_BS_ERRORRepository : BaseRepository<zzz_BS_ERROR>
    , Izzz_BS_ERRORRepository
    {
    private readonly Context _context;
    public zzz_BS_ERRORRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

