namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiGiaRepository : BaseRepository<DM_LoaiGia>
    , IDM_LoaiGiaRepository
    {
    private readonly Context _context;
    public DM_LoaiGiaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

