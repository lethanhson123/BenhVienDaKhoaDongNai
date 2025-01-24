namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuXuatBenhNhan_TestStentService : BaseService<ChungTuXuatBenhNhan_TestStent, IChungTuXuatBenhNhan_TestStentRepository>
    , IChungTuXuatBenhNhan_TestStentService
    {
    private readonly IChungTuXuatBenhNhan_TestStentRepository _ChungTuXuatBenhNhan_TestStentRepository;
    public ChungTuXuatBenhNhan_TestStentService(IChungTuXuatBenhNhan_TestStentRepository ChungTuXuatBenhNhan_TestStentRepository) : base(ChungTuXuatBenhNhan_TestStentRepository)
    {
    _ChungTuXuatBenhNhan_TestStentRepository = ChungTuXuatBenhNhan_TestStentRepository;
    }
    }
    }

