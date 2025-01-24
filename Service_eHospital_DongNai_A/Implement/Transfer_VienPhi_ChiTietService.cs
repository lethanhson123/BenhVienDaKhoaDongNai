namespace Service_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhi_ChiTietService : BaseService<Transfer_VienPhi_ChiTiet, ITransfer_VienPhi_ChiTietRepository>
    , ITransfer_VienPhi_ChiTietService
    {
    private readonly ITransfer_VienPhi_ChiTietRepository _Transfer_VienPhi_ChiTietRepository;
    public Transfer_VienPhi_ChiTietService(ITransfer_VienPhi_ChiTietRepository Transfer_VienPhi_ChiTietRepository) : base(Transfer_VienPhi_ChiTietRepository)
    {
    _Transfer_VienPhi_ChiTietRepository = Transfer_VienPhi_ChiTietRepository;
    }
    }
    }

