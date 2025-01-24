namespace Service_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhi_ChiTiet_TempService : BaseService<Transfer_VienPhi_ChiTiet_Temp, ITransfer_VienPhi_ChiTiet_TempRepository>
    , ITransfer_VienPhi_ChiTiet_TempService
    {
    private readonly ITransfer_VienPhi_ChiTiet_TempRepository _Transfer_VienPhi_ChiTiet_TempRepository;
    public Transfer_VienPhi_ChiTiet_TempService(ITransfer_VienPhi_ChiTiet_TempRepository Transfer_VienPhi_ChiTiet_TempRepository) : base(Transfer_VienPhi_ChiTiet_TempRepository)
    {
    _Transfer_VienPhi_ChiTiet_TempRepository = Transfer_VienPhi_ChiTiet_TempRepository;
    }
    }
    }

