namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChuyenChungTuRepository : BaseRepository<ChuyenChungTu>
    , IChuyenChungTuRepository
    {
    private readonly Context _context;
    public ChuyenChungTuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

