namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAn_PhucHinhRangRepository : BaseRepository<BenhAn_PhucHinhRang>
    , IBenhAn_PhucHinhRangRepository
    {
    private readonly Context _context;
    public BenhAn_PhucHinhRangRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

