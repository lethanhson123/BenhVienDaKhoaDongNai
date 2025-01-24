namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cust_Backup_BsCCHNRepository : BaseRepository<Cust_Backup_BsCCHN>
    , ICust_Backup_BsCCHNRepository
    {
    private readonly Context _context;
    public Cust_Backup_BsCCHNRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

