namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_MaBenhNhanRepository : BaseRepository<Lst_KeyData_MaBenhNhan>
    , ILst_KeyData_MaBenhNhanRepository
    {
    private readonly Context _context;
    public Lst_KeyData_MaBenhNhanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

