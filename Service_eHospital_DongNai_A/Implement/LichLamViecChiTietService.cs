namespace Service_eHospital_DongNai_A.Implement
{
    public class LichLamViecChiTietService : BaseService<LichLamViecChiTiet, ILichLamViecChiTietRepository>
    , ILichLamViecChiTietService
    {
    private readonly ILichLamViecChiTietRepository _LichLamViecChiTietRepository;
    public LichLamViecChiTietService(ILichLamViecChiTietRepository LichLamViecChiTietRepository) : base(LichLamViecChiTietRepository)
    {
    _LichLamViecChiTietRepository = LichLamViecChiTietRepository;
    }
    }
    }

