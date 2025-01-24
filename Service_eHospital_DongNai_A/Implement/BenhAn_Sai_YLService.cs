namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_Sai_YLService : BaseService<BenhAn_Sai_YL, IBenhAn_Sai_YLRepository>
    , IBenhAn_Sai_YLService
    {
    private readonly IBenhAn_Sai_YLRepository _BenhAn_Sai_YLRepository;
    public BenhAn_Sai_YLService(IBenhAn_Sai_YLRepository BenhAn_Sai_YLRepository) : base(BenhAn_Sai_YLRepository)
    {
    _BenhAn_Sai_YLRepository = BenhAn_Sai_YLRepository;
    }
    }
    }

