namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cus_NoiXuatRepository : BaseRepository<Cus_NoiXuat>
    , ICus_NoiXuatRepository
    {
    private readonly Context _context;
    public Cus_NoiXuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

