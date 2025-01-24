namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_TiepNhanRepository : BaseRepository<Lst_KeyData_TiepNhan>
    , ILst_KeyData_TiepNhanRepository
    {
    private readonly Context _context;
    public Lst_KeyData_TiepNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

