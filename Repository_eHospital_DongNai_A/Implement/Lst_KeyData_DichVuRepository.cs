namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_DichVuRepository : BaseRepository<Lst_KeyData_DichVu>
    , ILst_KeyData_DichVuRepository
    {
    private readonly Context _context;
    public Lst_KeyData_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

