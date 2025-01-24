namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_DonViHanhChinh_LTRepository : BaseRepository<DM_DonViHanhChinh_LT>
    , IDM_DonViHanhChinh_LTRepository
    {
    private readonly Context _context;
    public DM_DonViHanhChinh_LTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

