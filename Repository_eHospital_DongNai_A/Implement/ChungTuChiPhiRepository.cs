namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuChiPhiRepository : BaseRepository<ChungTuChiPhi>
    , IChungTuChiPhiRepository
    {
    private readonly Context _context;
    public ChungTuChiPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

