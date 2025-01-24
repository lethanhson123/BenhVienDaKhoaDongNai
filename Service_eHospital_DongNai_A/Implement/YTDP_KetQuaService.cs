namespace Service_eHospital_DongNai_A.Implement
{
    public class YTDP_KetQuaService : BaseService<YTDP_KetQua, IYTDP_KetQuaRepository>
    , IYTDP_KetQuaService
    {
    private readonly IYTDP_KetQuaRepository _YTDP_KetQuaRepository;
    public YTDP_KetQuaService(IYTDP_KetQuaRepository YTDP_KetQuaRepository) : base(YTDP_KetQuaRepository)
    {
    _YTDP_KetQuaRepository = YTDP_KetQuaRepository;
    }
    }
    }

