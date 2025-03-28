﻿
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
                model.DanhMucXaPhuongName = _DanhMucXaPhuongRepository.GetByID(model.DanhMucXaPhuongID.Value).Name;
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
            bool IsSave = true;
            KhachHang KhachHangCheck = await GetBySearchStringToAsync(model.Code);
            if (KhachHangCheck.ID > 0)
            {
                if (KhachHangCheck.ID != model.ID)
                {
                    IsSave = false;
                }
            }
            if (IsSave == true)
            {
                if (model.ID > 0)
                {
                    result = await UpdateAsync(model);
                }
                else
                {
                    result = await AddAsync(model);
                }
            }

            if (result > 0)
            {
            }
            return model;
        }
        public virtual async Task<KhachHang> GetBySearchStringToAsync(string SearchString)
        {
            KhachHang result = new KhachHang();
            try
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.Trim();
                    if (!string.IsNullOrEmpty(SearchString))
                    {
                        SearchString = SearchString.Split('|')[0];
                    }
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
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
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
                SearchString = SearchString.Trim();
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.Split('|')[0];
                }
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
                SearchString = SearchString.Trim();
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.Split('|')[0];
                }
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
                SearchString = SearchString.Trim();
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.Split('|')[0];
                }
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
                SearchString = SearchString.Trim();
                if (!string.IsNullOrEmpty(SearchString))
                {
                    SearchString = SearchString.Split('|')[0];
                }
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

