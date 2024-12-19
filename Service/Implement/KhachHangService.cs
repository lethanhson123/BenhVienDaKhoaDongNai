using Microsoft.IdentityModel.Tokens;

namespace Service.Implement
{
    public class KhachHangService : BaseService<KhachHang, IKhachHangRepository>
    , IKhachHangService
    {
        private readonly IKhachHangRepository _KhachHangRepository;

        private readonly IDanhMucTinhThanhRepository _DanhMucTinhThanhRepository;
        private readonly IDanhMucQuanHuyenRepository _DanhMucQuanHuyenRepository;
        private readonly IDanhMucXaPhuongRepository _DanhMucXaPhuongRepository;

        public KhachHangService(IKhachHangRepository KhachHangRepository


            , IDanhMucTinhThanhRepository DanhMucTinhThanhRepository
            , IDanhMucQuanHuyenRepository DanhMucQuanHuyenRepository
            , IDanhMucXaPhuongRepository DanhMucXaPhuongRepository

            ) : base(KhachHangRepository)
        {
            _KhachHangRepository = KhachHangRepository;

            _DanhMucTinhThanhRepository = DanhMucTinhThanhRepository;
            _DanhMucQuanHuyenRepository = DanhMucQuanHuyenRepository;
            _DanhMucXaPhuongRepository = DanhMucXaPhuongRepository;
        }
        public override void Initialization(KhachHang model)
        {
            BaseInitialization(model);
            if (model.DanhMucTinhThanhID > 0)
            {
                model.DanhMucTinhThanhName = _DanhMucTinhThanhRepository.GetByID(model.DanhMucTinhThanhID.Value).Name;
            }
            if (model.DanhMucQuanHuyenID > 0)
            {
                model.DanhMucQuanHuyenName = _DanhMucQuanHuyenRepository.GetByID(model.DanhMucQuanHuyenID.Value).Name;
            }
            if (model.DanhMucXaPhuongID > 0)
            {
                model.DanhMucXaPhuongName = _DanhMucTinhThanhRepository.GetByID(model.DanhMucXaPhuongID.Value).Name;
            }
            if (model.NamSinh == null)
            {
                if (model.NgaySinh != null)
                {
                    model.NamSinh = model.NgaySinh.Value.Year;
                }
            }
        }
        public override async Task<KhachHang> SaveAsync(KhachHang model)
        {
            int result = GlobalHelper.InitializationNumber;
            KhachHang KhachHang = new KhachHang();
            if (KhachHang.ID == 0)
            {
                if (!string.IsNullOrEmpty(model.Code))
                {
                    KhachHang = await GetByCondition(item => item.Code == model.Code).FirstOrDefaultAsync();
                    if (KhachHang == null)
                    {
                        KhachHang = new KhachHang();
                    }
                }
            }
            if (KhachHang.ID == 0)
            {
                if (!string.IsNullOrEmpty(model.BHYT))
                {
                    KhachHang = await GetByCondition(item => item.BHYT == model.BHYT).FirstOrDefaultAsync();
                    if (KhachHang == null)
                    {
                        KhachHang = new KhachHang();
                    }
                }
            }
            if (KhachHang.ID == 0)
            {
                if (!string.IsNullOrEmpty(model.CCCD))
                {
                    KhachHang = await GetByCondition(item => item.CCCD == model.CCCD).FirstOrDefaultAsync();
                    if (KhachHang == null)
                    {
                        KhachHang = new KhachHang();
                    }
                }
            }
            if (KhachHang.ID == 0)
            {
                if (!string.IsNullOrEmpty(model.DienThoai))
                {
                    KhachHang = await GetByCondition(item => item.DienThoai == model.DienThoai).FirstOrDefaultAsync();
                    if (KhachHang == null)
                    {
                        KhachHang = new KhachHang();
                    }
                }
            }
            if (KhachHang.ID > 0)
            {
                model.ID = KhachHang.ID;
            }
            if (model.ID > 0)
            {
                result = await UpdateAsync(model);
            }
            else
            {
                result = await AddAsync(model);
            }
            if (result > 0)
            {
            }
            return model;
        }
        public virtual async Task<KhachHang> GetBySearchStringToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetByCondition(item => item.Code == SearchString).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = await GetByCondition(item => item.BHYT == SearchString).FirstOrDefaultAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.CCCD == SearchString).FirstOrDefaultAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.DienThoai == SearchString).FirstOrDefaultAsync();
                }
            }
            if (result == null)
            {
                result = new KhachHang();
            }
            return result;
        }
        public virtual async Task<KhachHang> GetByCodeToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetByCondition(item => item.Code == SearchString).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new KhachHang();
            }
            return result;
        }
        public virtual async Task<KhachHang> GetByBHYTToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetByCondition(item => item.BHYT == SearchString).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new KhachHang();
            }
            return result;
        }
        public virtual async Task<KhachHang> GetByCCCDToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetByCondition(item => item.CCCD == SearchString).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new KhachHang();
            }
            return result;
        }
        public virtual async Task<KhachHang> GetByDienThoaiToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetByCondition(item => item.DienThoai == SearchString).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new KhachHang();
            }
            return result;
        }
    }
}

