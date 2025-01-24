namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cust_SyncHDDT_TempRepository : BaseRepository<Cust_SyncHDDT_Temp>
    , ICust_SyncHDDT_TempRepository
    {
    private readonly Context _context;
    public Cust_SyncHDDT_TempRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

