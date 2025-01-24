namespace Repository_eHospital_DongNai_A.Implement
{
    public class MienGiamNoiTruRepository : BaseRepository<MienGiamNoiTru>
    , IMienGiamNoiTruRepository
    {
    private readonly Context _context;
    public MienGiamNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

