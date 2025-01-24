namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_ShiftRepository : BaseRepository<His_Shift>
    , IHis_ShiftRepository
    {
    private readonly Context _context;
    public His_ShiftRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

