namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChuyenVienRepository : BaseRepository<ChuyenVien>
    , IChuyenVienRepository
    {
    private readonly Context _context;
    public ChuyenVienRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

