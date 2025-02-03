namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BangGiaRepository : BaseRepository<DM_BangGia>
    , IDM_BangGiaRepository
    {
    private readonly Context _context;
    public DM_BangGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

