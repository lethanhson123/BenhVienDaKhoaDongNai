namespace Repository_eHospital_DongNai_A.Implement
{
    public class BENHNHAN_THEATMRepository : BaseRepository<BENHNHAN_THEATM>
    , IBENHNHAN_THEATMRepository
    {
    private readonly Context _context;
    public BENHNHAN_THEATMRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

