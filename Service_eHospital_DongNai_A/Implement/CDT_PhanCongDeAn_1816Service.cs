namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_PhanCongDeAn_1816Service : BaseService<CDT_PhanCongDeAn_1816, ICDT_PhanCongDeAn_1816Repository>
    , ICDT_PhanCongDeAn_1816Service
    {
    private readonly ICDT_PhanCongDeAn_1816Repository _CDT_PhanCongDeAn_1816Repository;
    public CDT_PhanCongDeAn_1816Service(ICDT_PhanCongDeAn_1816Repository CDT_PhanCongDeAn_1816Repository) : base(CDT_PhanCongDeAn_1816Repository)
    {
    _CDT_PhanCongDeAn_1816Repository = CDT_PhanCongDeAn_1816Repository;
    }
    }
    }

