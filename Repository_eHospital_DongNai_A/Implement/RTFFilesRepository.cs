namespace Repository_eHospital_DongNai_A.Implement
{
    public class RTFFilesRepository : BaseRepository<RTFFiles>
    , IRTFFilesRepository
    {
    private readonly Context _context;
    public RTFFilesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

