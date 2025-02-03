namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class Sys_OperatorsRepository : BaseRepository<Sys_Operators>
    , ISys_OperatorsRepository
    {
    private readonly Context _context;
    public Sys_OperatorsRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

