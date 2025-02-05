namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_THONGTINUNGVIENRepository : BaseRepository<NS_THONGTINUNGVIEN>
    , INS_THONGTINUNGVIENRepository
    {
    private readonly Context _context;
    public NS_THONGTINUNGVIENRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

