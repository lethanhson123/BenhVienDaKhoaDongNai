namespace Service_eHospital_DongNai_A.Implement
{
    public class XML1Service : BaseService<XML1, IXML1Repository>
    , IXML1Service
    {
    private readonly IXML1Repository _XML1Repository;
    public XML1Service(IXML1Repository XML1Repository) : base(XML1Repository)
    {
    _XML1Repository = XML1Repository;
    }
    }
    }

