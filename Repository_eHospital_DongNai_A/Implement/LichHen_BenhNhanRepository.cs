namespace Repository_eHospital_DongNai_A.Implement
{
    public class LichHen_BenhNhanRepository : BaseRepository<LichHen_BenhNhan>
    , ILichHen_BenhNhanRepository
    {
    private readonly Context _context;
    public LichHen_BenhNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

