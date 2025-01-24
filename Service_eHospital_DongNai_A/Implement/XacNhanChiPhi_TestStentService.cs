namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhi_TestStentService : BaseService<XacNhanChiPhi_TestStent, IXacNhanChiPhi_TestStentRepository>
    , IXacNhanChiPhi_TestStentService
    {
    private readonly IXacNhanChiPhi_TestStentRepository _XacNhanChiPhi_TestStentRepository;
    public XacNhanChiPhi_TestStentService(IXacNhanChiPhi_TestStentRepository XacNhanChiPhi_TestStentRepository) : base(XacNhanChiPhi_TestStentRepository)
    {
    _XacNhanChiPhi_TestStentRepository = XacNhanChiPhi_TestStentRepository;
    }
    }
    }

