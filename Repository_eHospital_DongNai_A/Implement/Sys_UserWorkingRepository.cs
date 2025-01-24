namespace Repository_eHospital_DongNai_A.Implement
{
    public class Sys_UserWorkingRepository : BaseRepository<Sys_UserWorking>
    , ISys_UserWorkingRepository
    {
    private readonly Context _context;
    public Sys_UserWorkingRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

