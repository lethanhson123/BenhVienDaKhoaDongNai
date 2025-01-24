namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_NgoaiDanhMucService : BaseService<zzz_NgoaiDanhMuc, Izzz_NgoaiDanhMucRepository>
    , Izzz_NgoaiDanhMucService
    {
    private readonly Izzz_NgoaiDanhMucRepository _zzz_NgoaiDanhMucRepository;
    public zzz_NgoaiDanhMucService(Izzz_NgoaiDanhMucRepository zzz_NgoaiDanhMucRepository) : base(zzz_NgoaiDanhMucRepository)
    {
    _zzz_NgoaiDanhMucRepository = zzz_NgoaiDanhMucRepository;
    }
    }
    }

