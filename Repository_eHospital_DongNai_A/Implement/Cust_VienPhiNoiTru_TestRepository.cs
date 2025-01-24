namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_TestRepository : BaseRepository<Cust_VienPhiNoiTru_Test>
    , ICust_VienPhiNoiTru_TestRepository
    {
    private readonly Context _context;
    public Cust_VienPhiNoiTru_TestRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

