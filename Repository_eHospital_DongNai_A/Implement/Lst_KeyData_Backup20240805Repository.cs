namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_Backup20240805Repository : BaseRepository<Lst_KeyData_Backup20240805>
    , ILst_KeyData_Backup20240805Repository
    {
    private readonly Context _context;
    public Lst_KeyData_Backup20240805Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

