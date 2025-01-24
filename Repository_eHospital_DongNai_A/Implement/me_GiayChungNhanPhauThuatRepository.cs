namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_GiayChungNhanPhauThuatRepository : BaseRepository<me_GiayChungNhanPhauThuat>
    , Ime_GiayChungNhanPhauThuatRepository
    {
    private readonly Context _context;
    public me_GiayChungNhanPhauThuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

