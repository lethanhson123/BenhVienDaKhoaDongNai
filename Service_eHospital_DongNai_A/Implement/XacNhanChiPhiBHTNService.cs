namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiBHTNService : BaseService<XacNhanChiPhiBHTN, IXacNhanChiPhiBHTNRepository>
    , IXacNhanChiPhiBHTNService
    {
    private readonly IXacNhanChiPhiBHTNRepository _XacNhanChiPhiBHTNRepository;
    public XacNhanChiPhiBHTNService(IXacNhanChiPhiBHTNRepository XacNhanChiPhiBHTNRepository) : base(XacNhanChiPhiBHTNRepository)
    {
    _XacNhanChiPhiBHTNRepository = XacNhanChiPhiBHTNRepository;
    }
    }
    }

