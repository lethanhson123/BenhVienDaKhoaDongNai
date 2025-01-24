namespace Service_eHospital_DongNai_A.Implement
{
    public class HangDoi_PhongBan_ChiPhiService : BaseService<HangDoi_PhongBan_ChiPhi, IHangDoi_PhongBan_ChiPhiRepository>
    , IHangDoi_PhongBan_ChiPhiService
    {
    private readonly IHangDoi_PhongBan_ChiPhiRepository _HangDoi_PhongBan_ChiPhiRepository;
    public HangDoi_PhongBan_ChiPhiService(IHangDoi_PhongBan_ChiPhiRepository HangDoi_PhongBan_ChiPhiRepository) : base(HangDoi_PhongBan_ChiPhiRepository)
    {
    _HangDoi_PhongBan_ChiPhiRepository = HangDoi_PhongBan_ChiPhiRepository;
    }
    }
    }

