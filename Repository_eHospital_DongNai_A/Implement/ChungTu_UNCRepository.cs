namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTu_UNCRepository : BaseRepository<ChungTu_UNC>
    , IChungTu_UNCRepository
    {
    private readonly Context _context;
    public ChungTu_UNCRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

