namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_DieuTriRepository : BaseRepository<BenhAn_DieuTri>
    , IBenhAn_DieuTriRepository
    {
    private readonly Context _context;
    public BenhAn_DieuTriRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

