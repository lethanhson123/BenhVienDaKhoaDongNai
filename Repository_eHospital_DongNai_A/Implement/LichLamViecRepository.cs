namespace Repository_eHospital_DongNai_A.Implement
{
    public class LichLamViecRepository : BaseRepository<LichLamViec>
    , ILichLamViecRepository
    {
    private readonly Context _context;
    public LichLamViecRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

