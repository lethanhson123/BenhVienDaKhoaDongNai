namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_TrangThietBiTuyenDuoiRepository : BaseRepository<DM_TrangThietBiTuyenDuoi>
    , IDM_TrangThietBiTuyenDuoiRepository
    {
    private readonly Context _context;
    public DM_TrangThietBiTuyenDuoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

