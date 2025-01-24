namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangLanKhamRepository : BaseRepository<CSKH_The_TangLanKham>
    , ICSKH_The_TangLanKhamRepository
    {
    private readonly Context _context;
    public CSKH_The_TangLanKhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

