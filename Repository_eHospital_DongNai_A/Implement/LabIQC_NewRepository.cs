namespace Repository_eHospital_DongNai_A.Implement
{
    public class LabIQC_NewRepository : BaseRepository<LabIQC_New>
    , ILabIQC_NewRepository
    {
    private readonly Context _context;
    public LabIQC_NewRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

