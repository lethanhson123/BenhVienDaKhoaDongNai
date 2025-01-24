namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_DoiTheRepository : BaseRepository<CSKH_The_DoiThe>
    , ICSKH_The_DoiTheRepository
    {
    private readonly Context _context;
    public CSKH_The_DoiTheRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

