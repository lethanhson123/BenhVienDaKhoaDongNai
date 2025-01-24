namespace Service_eHospital_DongNai_A.Implement
{
    public class XML2Service : BaseService<XML2, IXML2Repository>
    , IXML2Service
    {
    private readonly IXML2Repository _XML2Repository;
    public XML2Service(IXML2Repository XML2Repository) : base(XML2Repository)
    {
    _XML2Repository = XML2Repository;
    }
    }
    }

