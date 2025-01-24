namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_DieuTriRangService : BaseService<BenhAn_DieuTriRang, IBenhAn_DieuTriRangRepository>
    , IBenhAn_DieuTriRangService
    {
    private readonly IBenhAn_DieuTriRangRepository _BenhAn_DieuTriRangRepository;
    public BenhAn_DieuTriRangService(IBenhAn_DieuTriRangRepository BenhAn_DieuTriRangRepository) : base(BenhAn_DieuTriRangRepository)
    {
    _BenhAn_DieuTriRangRepository = BenhAn_DieuTriRangRepository;
    }
    }
    }

