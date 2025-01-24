namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_UserRepository : BaseRepository<me_User>
    , Ime_UserRepository
    {
    private readonly Context _context;
    public me_UserRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

