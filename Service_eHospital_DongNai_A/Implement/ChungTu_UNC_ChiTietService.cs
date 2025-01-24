namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTu_UNC_ChiTietService : BaseService<ChungTu_UNC_ChiTiet, IChungTu_UNC_ChiTietRepository>
    , IChungTu_UNC_ChiTietService
    {
    private readonly IChungTu_UNC_ChiTietRepository _ChungTu_UNC_ChiTietRepository;
    public ChungTu_UNC_ChiTietService(IChungTu_UNC_ChiTietRepository ChungTu_UNC_ChiTietRepository) : base(ChungTu_UNC_ChiTietRepository)
    {
    _ChungTu_UNC_ChiTietRepository = ChungTu_UNC_ChiTietRepository;
    }
    }
    }

