namespace Repository_eHospital_DongNai_A.Implement
{
    public class ShiftDetailRepository : BaseRepository<ShiftDetail>
    , IShiftDetailRepository
    {
    private readonly Context _context;
    public ShiftDetailRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

