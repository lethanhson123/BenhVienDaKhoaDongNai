namespace Repository_eHospital_DongNai_A.Implement
{
    public class LyDoChuyenKhoaRepository : BaseRepository<LyDoChuyenKhoa>
    , ILyDoChuyenKhoaRepository
    {
    private readonly Context _context;
    public LyDoChuyenKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

