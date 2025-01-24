namespace Repository_eHospital_DongNai_A.Implement
{
    public class EMRRepository : BaseRepository<EMR>
    , IEMRRepository
    {
    private readonly Context _context;
    public EMRRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

