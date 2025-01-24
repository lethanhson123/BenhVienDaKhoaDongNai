namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangThePhuRepository : BaseRepository<CSKH_The_TangThePhu>
    , ICSKH_The_TangThePhuRepository
    {
    private readonly Context _context;
    public CSKH_The_TangThePhuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

