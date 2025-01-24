namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_20240710Repository : BaseRepository<DM_DonViHanhChinh_20240710>
    , IDM_DonViHanhChinh_20240710Repository
    {
    private readonly Context _context;
    public DM_DonViHanhChinh_20240710Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

