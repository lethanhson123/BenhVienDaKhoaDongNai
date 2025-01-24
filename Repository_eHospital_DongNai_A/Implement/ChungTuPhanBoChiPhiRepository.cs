namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChungTuPhanBoChiPhiRepository : BaseRepository<ChungTuPhanBoChiPhi>
    , IChungTuPhanBoChiPhiRepository
    {
    private readonly Context _context;
    public ChungTuPhanBoChiPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

