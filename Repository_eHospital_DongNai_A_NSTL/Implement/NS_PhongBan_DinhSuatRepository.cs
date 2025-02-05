namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_PhongBan_DinhSuatRepository : BaseRepository<NS_PhongBan_DinhSuat>
    , INS_PhongBan_DinhSuatRepository
    {
    private readonly Context _context;
    public NS_PhongBan_DinhSuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

