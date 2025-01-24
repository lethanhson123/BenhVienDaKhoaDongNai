namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_MauBenhRepository : BaseRepository<DM_MauBenh>
    , IDM_MauBenhRepository
    {
    private readonly Context _context;
    public DM_MauBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

