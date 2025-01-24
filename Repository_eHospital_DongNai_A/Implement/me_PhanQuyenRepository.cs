namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_PhanQuyenRepository : BaseRepository<me_PhanQuyen>
    , Ime_PhanQuyenRepository
    {
    private readonly Context _context;
    public me_PhanQuyenRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

