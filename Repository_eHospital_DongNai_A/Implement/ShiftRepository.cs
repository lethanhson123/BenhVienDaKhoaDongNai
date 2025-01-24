namespace Repository_eHospital_DongNai_A.Implement
{
    public class ShiftRepository : BaseRepository<Shift>
    , IShiftRepository
    {
    private readonly Context _context;
    public ShiftRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

