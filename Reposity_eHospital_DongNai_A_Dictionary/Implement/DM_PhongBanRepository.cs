namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_PhongBanRepository : BaseRepository<DM_PhongBan>
    , IDM_PhongBanRepository
    {
    private readonly Context _context;
    public DM_PhongBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

