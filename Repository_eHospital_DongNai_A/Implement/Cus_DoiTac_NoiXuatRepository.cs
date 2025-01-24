namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cus_DoiTac_NoiXuatRepository : BaseRepository<Cus_DoiTac_NoiXuat>
    , ICus_DoiTac_NoiXuatRepository
    {
    private readonly Context _context;
    public Cus_DoiTac_NoiXuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

