namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ServerRepository : BaseRepository<Sys_ModifySource_Server>
    , ISys_ModifySource_ServerRepository
    {
    private readonly Context _context;
    public Sys_ModifySource_ServerRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

