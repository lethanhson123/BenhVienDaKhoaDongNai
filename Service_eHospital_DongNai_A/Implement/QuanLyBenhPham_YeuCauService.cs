namespace Service_eHospital_DongNai_A.Implement
{
    public class QuanLyBenhPham_YeuCauService : BaseService<QuanLyBenhPham_YeuCau, IQuanLyBenhPham_YeuCauRepository>
    , IQuanLyBenhPham_YeuCauService
    {
    private readonly IQuanLyBenhPham_YeuCauRepository _QuanLyBenhPham_YeuCauRepository;
    public QuanLyBenhPham_YeuCauService(IQuanLyBenhPham_YeuCauRepository QuanLyBenhPham_YeuCauRepository) : base(QuanLyBenhPham_YeuCauRepository)
    {
    _QuanLyBenhPham_YeuCauRepository = QuanLyBenhPham_YeuCauRepository;
    }
    }
    }

