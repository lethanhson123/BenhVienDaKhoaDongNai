namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_046Repository : BaseRepository<ztmp_BCTN_046>
    , Iztmp_BCTN_046Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_046Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

