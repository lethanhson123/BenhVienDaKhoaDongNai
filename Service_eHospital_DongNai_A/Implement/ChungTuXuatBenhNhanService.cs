namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuXuatBenhNhanService : BaseService<ChungTuXuatBenhNhan, IChungTuXuatBenhNhanRepository>
    , IChungTuXuatBenhNhanService
    {
    private readonly IChungTuXuatBenhNhanRepository _ChungTuXuatBenhNhanRepository;
    public ChungTuXuatBenhNhanService(IChungTuXuatBenhNhanRepository ChungTuXuatBenhNhanRepository) : base(ChungTuXuatBenhNhanRepository)
    {
    _ChungTuXuatBenhNhanRepository = ChungTuXuatBenhNhanRepository;
    }
    }
    }

