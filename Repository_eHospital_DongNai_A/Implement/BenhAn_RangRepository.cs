namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_RangRepository : BaseRepository<BenhAn_Rang>
    , IBenhAn_RangRepository
    {
    private readonly Context _context;
    public BenhAn_RangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

