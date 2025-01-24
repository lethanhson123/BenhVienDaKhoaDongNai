namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_TestService : BaseService<Cust_VienPhiNoiTru_Test, ICust_VienPhiNoiTru_TestRepository>
    , ICust_VienPhiNoiTru_TestService
    {
    private readonly ICust_VienPhiNoiTru_TestRepository _Cust_VienPhiNoiTru_TestRepository;
    public Cust_VienPhiNoiTru_TestService(ICust_VienPhiNoiTru_TestRepository Cust_VienPhiNoiTru_TestRepository) : base(Cust_VienPhiNoiTru_TestRepository)
    {
    _Cust_VienPhiNoiTru_TestRepository = Cust_VienPhiNoiTru_TestRepository;
    }
    }
    }

