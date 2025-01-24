namespace Service_eHospital_DongNai_A.Implement
{
    public class XepLichMoService : BaseService<XepLichMo, IXepLichMoRepository>
    , IXepLichMoService
    {
    private readonly IXepLichMoRepository _XepLichMoRepository;
    public XepLichMoService(IXepLichMoRepository XepLichMoRepository) : base(XepLichMoRepository)
    {
    _XepLichMoRepository = XepLichMoRepository;
    }
    }
    }

