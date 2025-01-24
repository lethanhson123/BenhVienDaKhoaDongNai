namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_GioiHanRepository : BaseRepository<DuocTonKho_GioiHan>
    , IDuocTonKho_GioiHanRepository
    {
    private readonly Context _context;
    public DuocTonKho_GioiHanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

