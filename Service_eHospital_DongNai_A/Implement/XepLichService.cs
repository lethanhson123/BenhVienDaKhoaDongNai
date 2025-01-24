namespace Service_eHospital_DongNai_A.Implement
{
    public class XepLichService : BaseService<XepLich, IXepLichRepository>
    , IXepLichService
    {
    private readonly IXepLichRepository _XepLichRepository;
    public XepLichService(IXepLichRepository XepLichRepository) : base(XepLichRepository)
    {
    _XepLichRepository = XepLichRepository;
    }
    }
    }

