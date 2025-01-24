namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_ToaThuocService : BaseService<Lst_KeyData_ToaThuoc, ILst_KeyData_ToaThuocRepository>
    , ILst_KeyData_ToaThuocService
    {
    private readonly ILst_KeyData_ToaThuocRepository _Lst_KeyData_ToaThuocRepository;
    public Lst_KeyData_ToaThuocService(ILst_KeyData_ToaThuocRepository Lst_KeyData_ToaThuocRepository) : base(Lst_KeyData_ToaThuocRepository)
    {
    _Lst_KeyData_ToaThuocRepository = Lst_KeyData_ToaThuocRepository;
    }
    }
    }

