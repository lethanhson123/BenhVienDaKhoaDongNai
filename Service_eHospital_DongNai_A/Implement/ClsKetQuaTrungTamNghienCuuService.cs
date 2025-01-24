namespace Service_eHospital_DongNai_A.Implement
{
    public class ClsKetQuaTrungTamNghienCuuService : BaseService<ClsKetQuaTrungTamNghienCuu, IClsKetQuaTrungTamNghienCuuRepository>
    , IClsKetQuaTrungTamNghienCuuService
    {
    private readonly IClsKetQuaTrungTamNghienCuuRepository _ClsKetQuaTrungTamNghienCuuRepository;
    public ClsKetQuaTrungTamNghienCuuService(IClsKetQuaTrungTamNghienCuuRepository ClsKetQuaTrungTamNghienCuuRepository) : base(ClsKetQuaTrungTamNghienCuuRepository)
    {
    _ClsKetQuaTrungTamNghienCuuRepository = ClsKetQuaTrungTamNghienCuuRepository;
    }
    }
    }

