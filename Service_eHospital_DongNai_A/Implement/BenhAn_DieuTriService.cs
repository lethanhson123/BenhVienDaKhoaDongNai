namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_DieuTriService : BaseService<BenhAn_DieuTri, IBenhAn_DieuTriRepository>
    , IBenhAn_DieuTriService
    {
    private readonly IBenhAn_DieuTriRepository _BenhAn_DieuTriRepository;
    public BenhAn_DieuTriService(IBenhAn_DieuTriRepository BenhAn_DieuTriRepository) : base(BenhAn_DieuTriRepository)
    {
    _BenhAn_DieuTriRepository = BenhAn_DieuTriRepository;
    }
    }
    }

