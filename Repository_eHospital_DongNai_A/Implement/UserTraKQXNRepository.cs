namespace Repository_eHospital_DongNai_A.Implement
{
    public class UserTraKQXNRepository : BaseRepository<UserTraKQXN>
    , IUserTraKQXNRepository
    {
    private readonly Context _context;
    public UserTraKQXNRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

