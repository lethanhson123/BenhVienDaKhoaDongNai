namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_NguoiGioiThieuChiTietRepository : BaseRepository<me_NguoiGioiThieuChiTiet>
    , Ime_NguoiGioiThieuChiTietRepository
    {
    private readonly Context _context;
    public me_NguoiGioiThieuChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

