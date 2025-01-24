namespace Service_eHospital_DongNai_A.Implement
{
    public class YTDP_KetQuaChiTietService : BaseService<YTDP_KetQuaChiTiet, IYTDP_KetQuaChiTietRepository>
    , IYTDP_KetQuaChiTietService
    {
    private readonly IYTDP_KetQuaChiTietRepository _YTDP_KetQuaChiTietRepository;
    public YTDP_KetQuaChiTietService(IYTDP_KetQuaChiTietRepository YTDP_KetQuaChiTietRepository) : base(YTDP_KetQuaChiTietRepository)
    {
    _YTDP_KetQuaChiTietRepository = YTDP_KetQuaChiTietRepository;
    }
    }
    }

