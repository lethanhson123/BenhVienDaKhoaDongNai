namespace Service_eHospital_DongNai_A.Implement
{
    public class me_LichHenService : BaseService<me_LichHen, Ime_LichHenRepository>
    , Ime_LichHenService
    {
    private readonly Ime_LichHenRepository _me_LichHenRepository;
    public me_LichHenService(Ime_LichHenRepository me_LichHenRepository) : base(me_LichHenRepository)
    {
    _me_LichHenRepository = me_LichHenRepository;
    }
    }
    }

