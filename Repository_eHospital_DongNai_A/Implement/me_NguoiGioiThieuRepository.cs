namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_NguoiGioiThieuRepository : BaseRepository<me_NguoiGioiThieu>
    , Ime_NguoiGioiThieuRepository
    {
    private readonly Context _context;
    public me_NguoiGioiThieuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

