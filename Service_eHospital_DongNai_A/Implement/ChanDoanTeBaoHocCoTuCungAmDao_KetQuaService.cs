namespace Service_eHospital_DongNai_A.Implement
{
    public class ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService : BaseService<ChanDoanTeBaoHocCoTuCungAmDao_KetQua, IChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository>
    , IChanDoanTeBaoHocCoTuCungAmDao_KetQuaService
    {
    private readonly IChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository _ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository;
    public ChanDoanTeBaoHocCoTuCungAmDao_KetQuaService(IChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository) : base(ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository)
    {
    _ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository = ChanDoanTeBaoHocCoTuCungAmDao_KetQuaRepository;
    }
    }
    }

