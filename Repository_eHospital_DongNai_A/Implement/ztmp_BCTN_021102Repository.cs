namespace Repository_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021102Repository : BaseRepository<ztmp_BCTN_021102>
    , Iztmp_BCTN_021102Repository
    {
    private readonly Context _context;
    public ztmp_BCTN_021102Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

