namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiDichVuRepository : BaseRepository<DM_LoaiDichVu>
    , IDM_LoaiDichVuRepository
    {
    private readonly Context _context;
    public DM_LoaiDichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

