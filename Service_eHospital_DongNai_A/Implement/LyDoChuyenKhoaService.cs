namespace Service_eHospital_DongNai_A.Implement
{
    public class LyDoChuyenKhoaService : BaseService<LyDoChuyenKhoa, ILyDoChuyenKhoaRepository>
    , ILyDoChuyenKhoaService
    {
    private readonly ILyDoChuyenKhoaRepository _LyDoChuyenKhoaRepository;
    public LyDoChuyenKhoaService(ILyDoChuyenKhoaRepository LyDoChuyenKhoaRepository) : base(LyDoChuyenKhoaRepository)
    {
    _LyDoChuyenKhoaRepository = LyDoChuyenKhoaRepository;
    }
    }
    }

