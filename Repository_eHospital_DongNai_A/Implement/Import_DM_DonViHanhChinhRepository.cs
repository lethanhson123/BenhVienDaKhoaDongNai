namespace Repository_eHospital_DongNai_A.Implement
{
    public class Import_DM_DonViHanhChinhRepository : BaseRepository<Import_DM_DonViHanhChinh>
    , IImport_DM_DonViHanhChinhRepository
    {
    private readonly Context _context;
    public Import_DM_DonViHanhChinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

