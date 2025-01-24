namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_MauDienCoRepository : BaseRepository<DM_MauDienCo>
    , IDM_MauDienCoRepository
    {
    private readonly Context _context;
    public DM_MauDienCoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

