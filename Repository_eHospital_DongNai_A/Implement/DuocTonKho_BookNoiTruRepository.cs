namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookNoiTruRepository : BaseRepository<DuocTonKho_BookNoiTru>
    , IDuocTonKho_BookNoiTruRepository
    {
    private readonly Context _context;
    public DuocTonKho_BookNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

