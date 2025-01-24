namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSYeuCau_QMS_LogRepository : BaseRepository<CLSYeuCau_QMS_Log>
    , ICLSYeuCau_QMS_LogRepository
    {
    private readonly Context _context;
    public CLSYeuCau_QMS_LogRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

