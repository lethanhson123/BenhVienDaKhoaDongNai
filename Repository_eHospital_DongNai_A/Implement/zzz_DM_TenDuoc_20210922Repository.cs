namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_DM_TenDuoc_20210922Repository : BaseRepository<zzz_DM_TenDuoc_20210922>
    , Izzz_DM_TenDuoc_20210922Repository
    {
    private readonly Context _context;
    public zzz_DM_TenDuoc_20210922Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

