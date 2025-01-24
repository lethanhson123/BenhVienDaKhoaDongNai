namespace Service_eHospital_DongNai_A.Implement
{
    public class me_PhongBanService : BaseService<me_PhongBan, Ime_PhongBanRepository>
    , Ime_PhongBanService
    {
    private readonly Ime_PhongBanRepository _me_PhongBanRepository;
    public me_PhongBanService(Ime_PhongBanRepository me_PhongBanRepository) : base(me_PhongBanRepository)
    {
    _me_PhongBanRepository = me_PhongBanRepository;
    }
    }
    }

