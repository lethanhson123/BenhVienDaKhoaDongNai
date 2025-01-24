namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_ThoiHanSDTheRepository : BaseRepository<CSKH_The_ThoiHanSDThe>
    , ICSKH_The_ThoiHanSDTheRepository
    {
    private readonly Context _context;
    public CSKH_The_ThoiHanSDTheRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

