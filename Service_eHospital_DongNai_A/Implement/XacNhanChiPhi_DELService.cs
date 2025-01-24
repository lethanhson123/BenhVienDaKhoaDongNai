namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhi_DELService : BaseService<XacNhanChiPhi_DEL, IXacNhanChiPhi_DELRepository>
    , IXacNhanChiPhi_DELService
    {
    private readonly IXacNhanChiPhi_DELRepository _XacNhanChiPhi_DELRepository;
    public XacNhanChiPhi_DELService(IXacNhanChiPhi_DELRepository XacNhanChiPhi_DELRepository) : base(XacNhanChiPhi_DELRepository)
    {
    _XacNhanChiPhi_DELRepository = XacNhanChiPhi_DELRepository;
    }
    }
    }

