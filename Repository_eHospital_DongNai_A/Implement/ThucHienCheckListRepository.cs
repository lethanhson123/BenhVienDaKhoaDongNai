namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThucHienCheckListRepository : BaseRepository<ThucHienCheckList>
    , IThucHienCheckListRepository
    {
    private readonly Context _context;
    public ThucHienCheckListRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

