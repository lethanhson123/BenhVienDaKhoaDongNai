namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_RangService : BaseService<BenhAn_Rang, IBenhAn_RangRepository>
    , IBenhAn_RangService
    {
    private readonly IBenhAn_RangRepository _BenhAn_RangRepository;
    public BenhAn_RangService(IBenhAn_RangRepository BenhAn_RangRepository) : base(BenhAn_RangRepository)
    {
    _BenhAn_RangRepository = BenhAn_RangRepository;
    }
    }
    }

