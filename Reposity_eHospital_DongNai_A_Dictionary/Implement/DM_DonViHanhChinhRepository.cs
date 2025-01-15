namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DonViHanhChinhRepository : BaseRepository<DM_DonViHanhChinh>
    , IDM_DonViHanhChinhRepository
    {
    private readonly Context _context;
    public DM_DonViHanhChinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

