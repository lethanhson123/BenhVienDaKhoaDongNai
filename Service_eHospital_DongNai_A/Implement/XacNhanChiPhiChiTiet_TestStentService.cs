namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiChiTiet_TestStentService : BaseService<XacNhanChiPhiChiTiet_TestStent, IXacNhanChiPhiChiTiet_TestStentRepository>
    , IXacNhanChiPhiChiTiet_TestStentService
    {
    private readonly IXacNhanChiPhiChiTiet_TestStentRepository _XacNhanChiPhiChiTiet_TestStentRepository;
    public XacNhanChiPhiChiTiet_TestStentService(IXacNhanChiPhiChiTiet_TestStentRepository XacNhanChiPhiChiTiet_TestStentRepository) : base(XacNhanChiPhiChiTiet_TestStentRepository)
    {
    _XacNhanChiPhiChiTiet_TestStentRepository = XacNhanChiPhiChiTiet_TestStentRepository;
    }
    }
    }

