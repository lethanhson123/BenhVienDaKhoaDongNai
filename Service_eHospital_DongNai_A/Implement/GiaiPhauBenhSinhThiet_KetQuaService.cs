namespace Service_eHospital_DongNai_A.Implement
{
    public class GiaiPhauBenhSinhThiet_KetQuaService : BaseService<GiaiPhauBenhSinhThiet_KetQua, IGiaiPhauBenhSinhThiet_KetQuaRepository>
    , IGiaiPhauBenhSinhThiet_KetQuaService
    {
    private readonly IGiaiPhauBenhSinhThiet_KetQuaRepository _GiaiPhauBenhSinhThiet_KetQuaRepository;
    public GiaiPhauBenhSinhThiet_KetQuaService(IGiaiPhauBenhSinhThiet_KetQuaRepository GiaiPhauBenhSinhThiet_KetQuaRepository) : base(GiaiPhauBenhSinhThiet_KetQuaRepository)
    {
    _GiaiPhauBenhSinhThiet_KetQuaRepository = GiaiPhauBenhSinhThiet_KetQuaRepository;
    }
    }
    }

