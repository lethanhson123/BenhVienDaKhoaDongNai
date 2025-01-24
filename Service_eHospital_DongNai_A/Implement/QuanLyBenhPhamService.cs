namespace Service_eHospital_DongNai_A.Implement
{
    public class QuanLyBenhPhamService : BaseService<QuanLyBenhPham, IQuanLyBenhPhamRepository>
    , IQuanLyBenhPhamService
    {
    private readonly IQuanLyBenhPhamRepository _QuanLyBenhPhamRepository;
    public QuanLyBenhPhamService(IQuanLyBenhPhamRepository QuanLyBenhPhamRepository) : base(QuanLyBenhPhamRepository)
    {
    _QuanLyBenhPhamRepository = QuanLyBenhPhamRepository;
    }
    }
    }

