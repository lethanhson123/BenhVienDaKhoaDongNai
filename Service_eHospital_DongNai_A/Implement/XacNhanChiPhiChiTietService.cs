namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiChiTietService : BaseService<XacNhanChiPhiChiTiet, IXacNhanChiPhiChiTietRepository>
    , IXacNhanChiPhiChiTietService
    {
    private readonly IXacNhanChiPhiChiTietRepository _XacNhanChiPhiChiTietRepository;
    public XacNhanChiPhiChiTietService(IXacNhanChiPhiChiTietRepository XacNhanChiPhiChiTietRepository) : base(XacNhanChiPhiChiTietRepository)
    {
    _XacNhanChiPhiChiTietRepository = XacNhanChiPhiChiTietRepository;
    }
    }
    }

