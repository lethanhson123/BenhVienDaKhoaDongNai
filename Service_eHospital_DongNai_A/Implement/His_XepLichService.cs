namespace Service_eHospital_DongNai_A.Implement
{
    public class His_XepLichService : BaseService<His_XepLich, IHis_XepLichRepository>
    , IHis_XepLichService
    {
    private readonly IHis_XepLichRepository _His_XepLichRepository;
    public His_XepLichService(IHis_XepLichRepository His_XepLichRepository) : base(His_XepLichRepository)
    {
    _His_XepLichRepository = His_XepLichRepository;
    }
    }
    }

