namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhanCapCuuChiTietService : BaseService<TiepNhanCapCuuChiTiet, ITiepNhanCapCuuChiTietRepository>
    , ITiepNhanCapCuuChiTietService
    {
    private readonly ITiepNhanCapCuuChiTietRepository _TiepNhanCapCuuChiTietRepository;
    public TiepNhanCapCuuChiTietService(ITiepNhanCapCuuChiTietRepository TiepNhanCapCuuChiTietRepository) : base(TiepNhanCapCuuChiTietRepository)
    {
    _TiepNhanCapCuuChiTietRepository = TiepNhanCapCuuChiTietRepository;
    }
    }
    }

