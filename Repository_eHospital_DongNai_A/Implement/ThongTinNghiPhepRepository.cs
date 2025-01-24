namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThongTinNghiPhepRepository : BaseRepository<ThongTinNghiPhep>
    , IThongTinNghiPhepRepository
    {
    private readonly Context _context;
    public ThongTinNghiPhepRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

