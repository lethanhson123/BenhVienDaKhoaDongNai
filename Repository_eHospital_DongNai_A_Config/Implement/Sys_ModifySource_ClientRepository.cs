namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ClientRepository : BaseRepository<Sys_ModifySource_Client>
    , ISys_ModifySource_ClientRepository
    {
    private readonly Context _context;
    public Sys_ModifySource_ClientRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

