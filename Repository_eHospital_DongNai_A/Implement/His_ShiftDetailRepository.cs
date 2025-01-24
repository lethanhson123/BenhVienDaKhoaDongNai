namespace Repository_eHospital_DongNai_A.Implement
{
    public class His_ShiftDetailRepository : BaseRepository<His_ShiftDetail>
    , IHis_ShiftDetailRepository
    {
    private readonly Context _context;
    public His_ShiftDetailRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

