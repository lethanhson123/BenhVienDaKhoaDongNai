namespace Service_eHospital_DongNai_A.Implement
{
    public class XML3Service : BaseService<XML3, IXML3Repository>
    , IXML3Service
    {
    private readonly IXML3Repository _XML3Repository;
    public XML3Service(IXML3Repository XML3Repository) : base(XML3Repository)
    {
    _XML3Repository = XML3Repository;
    }
    }
    }

