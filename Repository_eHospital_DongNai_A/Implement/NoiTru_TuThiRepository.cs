namespace Repository_eHospital_DongNai_A.Implement
{
    public class NoiTru_TuThiRepository : BaseRepository<NoiTru_TuThi>
    , INoiTru_TuThiRepository
    {
    private readonly Context _context;
    public NoiTru_TuThiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

