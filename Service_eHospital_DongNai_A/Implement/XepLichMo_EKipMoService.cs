namespace Service_eHospital_DongNai_A.Implement
{
    public class XepLichMo_EKipMoService : BaseService<XepLichMo_EKipMo, IXepLichMo_EKipMoRepository>
    , IXepLichMo_EKipMoService
    {
    private readonly IXepLichMo_EKipMoRepository _XepLichMo_EKipMoRepository;
    public XepLichMo_EKipMoService(IXepLichMo_EKipMoRepository XepLichMo_EKipMoRepository) : base(XepLichMo_EKipMoRepository)
    {
    _XepLichMo_EKipMoRepository = XepLichMo_EKipMoRepository;
    }
    }
    }

