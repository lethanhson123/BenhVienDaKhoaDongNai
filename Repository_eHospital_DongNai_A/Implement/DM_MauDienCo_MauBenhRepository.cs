namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_MauDienCo_MauBenhRepository : BaseRepository<DM_MauDienCo_MauBenh>
    , IDM_MauDienCo_MauBenhRepository
    {
    private readonly Context _context;
    public DM_MauDienCo_MauBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

