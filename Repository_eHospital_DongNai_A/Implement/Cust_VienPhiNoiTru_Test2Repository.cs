namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_Test2Repository : BaseRepository<Cust_VienPhiNoiTru_Test2>
    , ICust_VienPhiNoiTru_Test2Repository
    {
    private readonly Context _context;
    public Cust_VienPhiNoiTru_Test2Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

