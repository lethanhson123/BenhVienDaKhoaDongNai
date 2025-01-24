namespace Service_eHospital_DongNai_A.Implement
{
    public class ChiPhiChiTiet_DoiTuongService : BaseService<ChiPhiChiTiet_DoiTuong, IChiPhiChiTiet_DoiTuongRepository>
    , IChiPhiChiTiet_DoiTuongService
    {
    private readonly IChiPhiChiTiet_DoiTuongRepository _ChiPhiChiTiet_DoiTuongRepository;
    public ChiPhiChiTiet_DoiTuongService(IChiPhiChiTiet_DoiTuongRepository ChiPhiChiTiet_DoiTuongRepository) : base(ChiPhiChiTiet_DoiTuongRepository)
    {
    _ChiPhiChiTiet_DoiTuongRepository = ChiPhiChiTiet_DoiTuongRepository;
    }
    }
    }

