namespace Repository_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_ToaThuocRepository : BaseRepository<Lst_KeyData_ToaThuoc>
    , ILst_KeyData_ToaThuocRepository
    {
    private readonly Context _context;
    public Lst_KeyData_ToaThuocRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

