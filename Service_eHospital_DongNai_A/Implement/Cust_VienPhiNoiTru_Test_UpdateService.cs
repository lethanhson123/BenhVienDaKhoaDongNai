namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_Test_UpdateService : BaseService<Cust_VienPhiNoiTru_Test_Update, ICust_VienPhiNoiTru_Test_UpdateRepository>
    , ICust_VienPhiNoiTru_Test_UpdateService
    {
    private readonly ICust_VienPhiNoiTru_Test_UpdateRepository _Cust_VienPhiNoiTru_Test_UpdateRepository;
    public Cust_VienPhiNoiTru_Test_UpdateService(ICust_VienPhiNoiTru_Test_UpdateRepository Cust_VienPhiNoiTru_Test_UpdateRepository) : base(Cust_VienPhiNoiTru_Test_UpdateRepository)
    {
    _Cust_VienPhiNoiTru_Test_UpdateRepository = Cust_VienPhiNoiTru_Test_UpdateRepository;
    }
    }
    }

