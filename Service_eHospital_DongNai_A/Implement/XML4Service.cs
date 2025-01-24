namespace Service_eHospital_DongNai_A.Implement
{
    public class XML4Service : BaseService<XML4, IXML4Repository>
    , IXML4Service
    {
    private readonly IXML4Repository _XML4Repository;
    public XML4Service(IXML4Repository XML4Repository) : base(XML4Repository)
    {
    _XML4Repository = XML4Repository;
    }
    }
    }

