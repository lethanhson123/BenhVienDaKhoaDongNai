namespace Service_eHospital_DongNai_A.Implement
{
    public class Transfer_VienPhiService : BaseService<Transfer_VienPhi, ITransfer_VienPhiRepository>
    , ITransfer_VienPhiService
    {
    private readonly ITransfer_VienPhiRepository _Transfer_VienPhiRepository;
    public Transfer_VienPhiService(ITransfer_VienPhiRepository Transfer_VienPhiRepository) : base(Transfer_VienPhiRepository)
    {
    _Transfer_VienPhiRepository = Transfer_VienPhiRepository;
    }
    }
    }

