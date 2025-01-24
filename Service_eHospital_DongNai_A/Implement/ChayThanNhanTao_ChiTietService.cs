namespace Service_eHospital_DongNai_A.Implement
{
    public class ChayThanNhanTao_ChiTietService : BaseService<ChayThanNhanTao_ChiTiet, IChayThanNhanTao_ChiTietRepository>
    , IChayThanNhanTao_ChiTietService
    {
    private readonly IChayThanNhanTao_ChiTietRepository _ChayThanNhanTao_ChiTietRepository;
    public ChayThanNhanTao_ChiTietService(IChayThanNhanTao_ChiTietRepository ChayThanNhanTao_ChiTietRepository) : base(ChayThanNhanTao_ChiTietRepository)
    {
    _ChayThanNhanTao_ChiTietRepository = ChayThanNhanTao_ChiTietRepository;
    }
    }
    }

