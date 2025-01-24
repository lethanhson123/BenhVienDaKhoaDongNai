namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_PhamViRepository : BaseRepository<DM_PhamVi>
    , IDM_PhamViRepository
    {
    private readonly Context _context;
    public DM_PhamViRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

