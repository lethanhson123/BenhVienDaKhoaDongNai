namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_DuocPhamService : BaseService<Lst_KeyData_DuocPham, ILst_KeyData_DuocPhamRepository>
    , ILst_KeyData_DuocPhamService
    {
    private readonly ILst_KeyData_DuocPhamRepository _Lst_KeyData_DuocPhamRepository;
    public Lst_KeyData_DuocPhamService(ILst_KeyData_DuocPhamRepository Lst_KeyData_DuocPhamRepository) : base(Lst_KeyData_DuocPhamRepository)
    {
    _Lst_KeyData_DuocPhamRepository = Lst_KeyData_DuocPhamRepository;
    }
    }
    }

