namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_MauBenh_ColumnRepository : BaseRepository<DM_MauBenh_Column>
    , IDM_MauBenh_ColumnRepository
    {
    private readonly Context _context;
    public DM_MauBenh_ColumnRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

