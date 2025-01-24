namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_DieuTriRangRepository : BaseRepository<BenhAn_DieuTriRang>
    , IBenhAn_DieuTriRangRepository
    {
    private readonly Context _context;
    public BenhAn_DieuTriRangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

