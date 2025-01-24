namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_VienPhiRepository : BaseRepository<Lst_KeyData_VienPhi>
    , ILst_KeyData_VienPhiRepository
    {
    private readonly Context _context;
    public Lst_KeyData_VienPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

