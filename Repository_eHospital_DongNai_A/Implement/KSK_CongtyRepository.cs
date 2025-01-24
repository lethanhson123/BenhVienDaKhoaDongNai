namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_CongtyRepository : BaseRepository<KSK_Congty>
    , IKSK_CongtyRepository
    {
    private readonly Context _context;
    public KSK_CongtyRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

