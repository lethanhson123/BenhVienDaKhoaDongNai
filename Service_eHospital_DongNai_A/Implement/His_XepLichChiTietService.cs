namespace Service_eHospital_DongNai_A.Implement
{
    public class His_XepLichChiTietService : BaseService<His_XepLichChiTiet, IHis_XepLichChiTietRepository>
    , IHis_XepLichChiTietService
    {
    private readonly IHis_XepLichChiTietRepository _His_XepLichChiTietRepository;
    public His_XepLichChiTietService(IHis_XepLichChiTietRepository His_XepLichChiTietRepository) : base(His_XepLichChiTietRepository)
    {
    _His_XepLichChiTietRepository = His_XepLichChiTietRepository;
    }
    }
    }

