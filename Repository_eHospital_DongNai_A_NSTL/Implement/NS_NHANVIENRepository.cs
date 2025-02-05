namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NHANVIENRepository : BaseRepository<NS_NHANVIEN>
    , INS_NHANVIENRepository
    {
    private readonly Context _context;
    public NS_NHANVIENRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

