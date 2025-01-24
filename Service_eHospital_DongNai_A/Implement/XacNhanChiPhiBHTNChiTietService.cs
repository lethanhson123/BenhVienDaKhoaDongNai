namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanChiPhiBHTNChiTietService : BaseService<XacNhanChiPhiBHTNChiTiet, IXacNhanChiPhiBHTNChiTietRepository>
    , IXacNhanChiPhiBHTNChiTietService
    {
    private readonly IXacNhanChiPhiBHTNChiTietRepository _XacNhanChiPhiBHTNChiTietRepository;
    public XacNhanChiPhiBHTNChiTietService(IXacNhanChiPhiBHTNChiTietRepository XacNhanChiPhiBHTNChiTietRepository) : base(XacNhanChiPhiBHTNChiTietRepository)
    {
    _XacNhanChiPhiBHTNChiTietRepository = XacNhanChiPhiBHTNChiTietRepository;
    }
    }
    }

