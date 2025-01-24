namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_Test2_UpdateService : BaseService<Cust_VienPhiNoiTru_Test2_Update, ICust_VienPhiNoiTru_Test2_UpdateRepository>
    , ICust_VienPhiNoiTru_Test2_UpdateService
    {
    private readonly ICust_VienPhiNoiTru_Test2_UpdateRepository _Cust_VienPhiNoiTru_Test2_UpdateRepository;
    public Cust_VienPhiNoiTru_Test2_UpdateService(ICust_VienPhiNoiTru_Test2_UpdateRepository Cust_VienPhiNoiTru_Test2_UpdateRepository) : base(Cust_VienPhiNoiTru_Test2_UpdateRepository)
    {
    _Cust_VienPhiNoiTru_Test2_UpdateRepository = Cust_VienPhiNoiTru_Test2_UpdateRepository;
    }
    }
    }

