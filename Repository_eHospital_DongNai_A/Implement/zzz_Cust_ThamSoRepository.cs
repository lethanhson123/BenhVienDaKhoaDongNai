namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_Cust_ThamSoRepository : BaseRepository<zzz_Cust_ThamSo>
    , Izzz_Cust_ThamSoRepository
    {
    private readonly Context _context;
    public zzz_Cust_ThamSoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

