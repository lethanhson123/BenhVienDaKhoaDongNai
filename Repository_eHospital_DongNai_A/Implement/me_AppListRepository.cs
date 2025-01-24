namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_AppListRepository : BaseRepository<me_AppList>
    , Ime_AppListRepository
    {
    private readonly Context _context;
    public me_AppListRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

