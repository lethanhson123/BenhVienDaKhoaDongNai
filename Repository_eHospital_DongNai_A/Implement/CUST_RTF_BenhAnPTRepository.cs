namespace Repository_eHospital_DongNai_A.Implement
{
    public class CUST_RTF_BenhAnPTRepository : BaseRepository<CUST_RTF_BenhAnPT>
    , ICUST_RTF_BenhAnPTRepository
    {
    private readonly Context _context;
    public CUST_RTF_BenhAnPTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

