namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyDataRepository : BaseRepository<Lst_KeyData>
    , ILst_KeyDataRepository
    {
    private readonly Context _context;
    public Lst_KeyDataRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

