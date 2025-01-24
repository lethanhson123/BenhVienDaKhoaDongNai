namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiService : BaseService<XacNhanChiPhi, IXacNhanChiPhiRepository>
    , IXacNhanChiPhiService
    {
    private readonly IXacNhanChiPhiRepository _XacNhanChiPhiRepository;
    public XacNhanChiPhiService(IXacNhanChiPhiRepository XacNhanChiPhiRepository) : base(XacNhanChiPhiRepository)
    {
    _XacNhanChiPhiRepository = XacNhanChiPhiRepository;
    }
    }
    }

