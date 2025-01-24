namespace Service_eHospital_DongNai_A.Implement
{
    public class XML5Service : BaseService<XML5, IXML5Repository>
    , IXML5Service
    {
    private readonly IXML5Repository _XML5Repository;
    public XML5Service(IXML5Repository XML5Repository) : base(XML5Repository)
    {
    _XML5Repository = XML5Repository;
    }
    }
    }

