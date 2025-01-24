namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_Mapping_DoiTuong_2KhuRepository : BaseRepository<DM_Mapping_DoiTuong_2Khu>
    , IDM_Mapping_DoiTuong_2KhuRepository
    {
    private readonly Context _context;
    public DM_Mapping_DoiTuong_2KhuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

