namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_20231114Repository : BaseRepository<DM_DonViHanhChinh_20231114>
    , IDM_DonViHanhChinh_20231114Repository
    {
    private readonly Context _context;
    public DM_DonViHanhChinh_20231114Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

