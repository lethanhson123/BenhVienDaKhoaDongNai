namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_TheRepository : BaseRepository<CSKH_The>
    , ICSKH_TheRepository
    {
    private readonly Context _context;
    public CSKH_TheRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

