namespace Service_eHospital_DongNai_A.Implement
{
    public class LienThongHoSoSucKhoeService : BaseService<LienThongHoSoSucKhoe, ILienThongHoSoSucKhoeRepository>
    , ILienThongHoSoSucKhoeService
    {
    private readonly ILienThongHoSoSucKhoeRepository _LienThongHoSoSucKhoeRepository;
    public LienThongHoSoSucKhoeService(ILienThongHoSoSucKhoeRepository LienThongHoSoSucKhoeRepository) : base(LienThongHoSoSucKhoeRepository)
    {
    _LienThongHoSoSucKhoeRepository = LienThongHoSoSucKhoeRepository;
    }
    }
    }

