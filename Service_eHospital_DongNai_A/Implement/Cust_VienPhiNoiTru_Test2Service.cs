namespace Service_eHospital_DongNai_A.Implement
{
    public class Cust_VienPhiNoiTru_Test2Service : BaseService<Cust_VienPhiNoiTru_Test2, ICust_VienPhiNoiTru_Test2Repository>
    , ICust_VienPhiNoiTru_Test2Service
    {
    private readonly ICust_VienPhiNoiTru_Test2Repository _Cust_VienPhiNoiTru_Test2Repository;
    public Cust_VienPhiNoiTru_Test2Service(ICust_VienPhiNoiTru_Test2Repository Cust_VienPhiNoiTru_Test2Repository) : base(Cust_VienPhiNoiTru_Test2Repository)
    {
    _Cust_VienPhiNoiTru_Test2Repository = Cust_VienPhiNoiTru_Test2Repository;
    }
    }
    }

