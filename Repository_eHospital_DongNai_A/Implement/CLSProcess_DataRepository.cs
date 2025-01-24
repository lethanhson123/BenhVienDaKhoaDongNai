namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSProcess_DataRepository : BaseRepository<CLSProcess_Data>
    , ICLSProcess_DataRepository
    {
    private readonly Context _context;
    public CLSProcess_DataRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

