namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_KhuVuc_UserRepository : BaseRepository<me_KhuVuc_User>
    , Ime_KhuVuc_UserRepository
    {
    private readonly Context _context;
    public me_KhuVuc_UserRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

