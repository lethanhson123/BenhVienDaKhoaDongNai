namespace Repository_eHospital_DongNai_A.Implement
{
    public class CUST_DonGiaMua_SoLeRepository : BaseRepository<CUST_DonGiaMua_SoLe>
    , ICUST_DonGiaMua_SoLeRepository
    {
    private readonly Context _context;
    public CUST_DonGiaMua_SoLeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

