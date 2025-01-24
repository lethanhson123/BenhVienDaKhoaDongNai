namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_Test_UpdateRepository : BaseRepository<Cust_VienPhiNoiTru_Test_Update>
    , ICust_VienPhiNoiTru_Test_UpdateRepository
    {
    private readonly Context _context;
    public Cust_VienPhiNoiTru_Test_UpdateRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

