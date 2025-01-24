namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookPhamViService : BaseService<DuocTonKho_BookPhamVi, IDuocTonKho_BookPhamViRepository>
    , IDuocTonKho_BookPhamViService
    {
    private readonly IDuocTonKho_BookPhamViRepository _DuocTonKho_BookPhamViRepository;
    public DuocTonKho_BookPhamViService(IDuocTonKho_BookPhamViRepository DuocTonKho_BookPhamViRepository) : base(DuocTonKho_BookPhamViRepository)
    {
    _DuocTonKho_BookPhamViRepository = DuocTonKho_BookPhamViRepository;
    }
    }
    }

