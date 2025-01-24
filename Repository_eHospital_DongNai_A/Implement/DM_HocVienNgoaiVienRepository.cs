namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_HocVienNgoaiVienRepository : BaseRepository<DM_HocVienNgoaiVien>
    , IDM_HocVienNgoaiVienRepository
    {
    private readonly Context _context;
    public DM_HocVienNgoaiVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

