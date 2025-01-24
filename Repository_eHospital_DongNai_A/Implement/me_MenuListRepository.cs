namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_MenuListRepository : BaseRepository<me_MenuList>
    , Ime_MenuListRepository
    {
    private readonly Context _context;
    public me_MenuListRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

