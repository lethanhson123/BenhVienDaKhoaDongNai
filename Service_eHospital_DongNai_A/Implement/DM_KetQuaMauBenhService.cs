namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_KetQuaMauBenhService : BaseService<DM_KetQuaMauBenh, IDM_KetQuaMauBenhRepository>
    , IDM_KetQuaMauBenhService
    {
    private readonly IDM_KetQuaMauBenhRepository _DM_KetQuaMauBenhRepository;
    public DM_KetQuaMauBenhService(IDM_KetQuaMauBenhRepository DM_KetQuaMauBenhRepository) : base(DM_KetQuaMauBenhRepository)
    {
    _DM_KetQuaMauBenhRepository = DM_KetQuaMauBenhRepository;
    }
    }
    }

