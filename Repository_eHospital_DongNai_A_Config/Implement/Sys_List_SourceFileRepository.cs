namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_List_SourceFileRepository : BaseRepository<Sys_List_SourceFile>
    , ISys_List_SourceFileRepository
    {
    private readonly Context _context;
    public Sys_List_SourceFileRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

