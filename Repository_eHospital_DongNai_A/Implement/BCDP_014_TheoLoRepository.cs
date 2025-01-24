namespace Repository_eHospital_DongNai_A.Implement
{
    public class BCDP_014_TheoLoRepository : BaseRepository<BCDP_014_TheoLo>
    , IBCDP_014_TheoLoRepository
    {
    private readonly Context _context;
    public BCDP_014_TheoLoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

