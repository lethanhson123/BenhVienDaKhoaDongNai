namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_HistoryDefinesRepository : BaseRepository<Sys_HistoryDefines>
    , ISys_HistoryDefinesRepository
    {
    private readonly Context _context;
    public Sys_HistoryDefinesRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

