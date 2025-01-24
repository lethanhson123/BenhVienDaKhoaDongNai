namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_VienPhiService : BaseService<Lst_KeyData_VienPhi, ILst_KeyData_VienPhiRepository>
    , ILst_KeyData_VienPhiService
    {
    private readonly ILst_KeyData_VienPhiRepository _Lst_KeyData_VienPhiRepository;
    public Lst_KeyData_VienPhiService(ILst_KeyData_VienPhiRepository Lst_KeyData_VienPhiRepository) : base(Lst_KeyData_VienPhiRepository)
    {
    _Lst_KeyData_VienPhiRepository = Lst_KeyData_VienPhiRepository;
    }
    }
    }

