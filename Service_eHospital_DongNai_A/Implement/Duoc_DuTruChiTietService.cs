namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_DuTruChiTietService : BaseService<Duoc_DuTruChiTiet, IDuoc_DuTruChiTietRepository>
    , IDuoc_DuTruChiTietService
    {
    private readonly IDuoc_DuTruChiTietRepository _Duoc_DuTruChiTietRepository;
    public Duoc_DuTruChiTietService(IDuoc_DuTruChiTietRepository Duoc_DuTruChiTietRepository) : base(Duoc_DuTruChiTietRepository)
    {
    _Duoc_DuTruChiTietRepository = Duoc_DuTruChiTietRepository;
    }
    }
    }

