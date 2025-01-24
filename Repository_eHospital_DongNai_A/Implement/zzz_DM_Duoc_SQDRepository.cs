namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_DM_Duoc_SQDRepository : BaseRepository<zzz_DM_Duoc_SQD>
    , Izzz_DM_Duoc_SQDRepository
    {
    private readonly Context _context;
    public zzz_DM_Duoc_SQDRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

