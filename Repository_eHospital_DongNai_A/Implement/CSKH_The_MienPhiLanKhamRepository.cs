namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_MienPhiLanKhamRepository : BaseRepository<CSKH_The_MienPhiLanKham>
    , ICSKH_The_MienPhiLanKhamRepository
    {
    private readonly Context _context;
    public CSKH_The_MienPhiLanKhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

