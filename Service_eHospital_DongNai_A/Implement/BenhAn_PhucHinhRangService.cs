namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_PhucHinhRangService : BaseService<BenhAn_PhucHinhRang, IBenhAn_PhucHinhRangRepository>
    , IBenhAn_PhucHinhRangService
    {
    private readonly IBenhAn_PhucHinhRangRepository _BenhAn_PhucHinhRangRepository;
    public BenhAn_PhucHinhRangService(IBenhAn_PhucHinhRangRepository BenhAn_PhucHinhRangRepository) : base(BenhAn_PhucHinhRangRepository)
    {
    _BenhAn_PhucHinhRangRepository = BenhAn_PhucHinhRangRepository;
    }
    }
    }

