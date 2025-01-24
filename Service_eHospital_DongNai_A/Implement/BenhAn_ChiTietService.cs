namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_ChiTietService : BaseService<BenhAn_ChiTiet, IBenhAn_ChiTietRepository>
    , IBenhAn_ChiTietService
    {
    private readonly IBenhAn_ChiTietRepository _BenhAn_ChiTietRepository;
    public BenhAn_ChiTietService(IBenhAn_ChiTietRepository BenhAn_ChiTietRepository) : base(BenhAn_ChiTietRepository)
    {
    _BenhAn_ChiTietRepository = BenhAn_ChiTietRepository;
    }
    }
    }

