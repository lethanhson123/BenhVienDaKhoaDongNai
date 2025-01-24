namespace Service_eHospital_DongNai_A.Implement
{
    public class XacNhanSuDungService : BaseService<XacNhanSuDung, IXacNhanSuDungRepository>
    , IXacNhanSuDungService
    {
    private readonly IXacNhanSuDungRepository _XacNhanSuDungRepository;
    public XacNhanSuDungService(IXacNhanSuDungRepository XacNhanSuDungRepository) : base(XacNhanSuDungRepository)
    {
    _XacNhanSuDungRepository = XacNhanSuDungRepository;
    }
    }
    }

