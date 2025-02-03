namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_ModifySource_ComputerRepository : BaseRepository<Sys_ModifySource_Computer>
    , ISys_ModifySource_ComputerRepository
    {
    private readonly Context _context;
    public Sys_ModifySource_ComputerRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

