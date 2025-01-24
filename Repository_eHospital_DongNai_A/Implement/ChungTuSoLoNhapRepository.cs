namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuSoLoNhapRepository : BaseRepository<ChungTuSoLoNhap>
    , IChungTuSoLoNhapRepository
    {
    private readonly Context _context;
    public ChungTuSoLoNhapRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

