namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_Sai_YLRepository : BaseRepository<BenhAn_Sai_YL>
    , IBenhAn_Sai_YLRepository
    {
    private readonly Context _context;
    public BenhAn_Sai_YLRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

