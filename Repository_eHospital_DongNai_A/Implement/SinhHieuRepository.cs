namespace Repository_eHospital_DongNai_A.Implement
{
    public class SinhHieuRepository : BaseRepository<SinhHieu>
    , ISinhHieuRepository
    {
    private readonly Context _context;
    public SinhHieuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

