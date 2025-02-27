using Service_eHospital_DongNai_A_Dictionary.Interface;
using System.Drawing.Printing;

namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhNhanService : BaseService<DM_BenhNhan, IDM_BenhNhanRepository>
    , IDM_BenhNhanService
    {
        private readonly IDM_BenhNhanRepository _DM_BenhNhanRepository;
        public DM_BenhNhanService(IDM_BenhNhanRepository DM_BenhNhanRepository) : base(DM_BenhNhanRepository)
        {
            _DM_BenhNhanRepository = DM_BenhNhanRepository;
        }
        public override async Task<DM_BenhNhan> SaveAsync(DM_BenhNhan model)
        {
            if (model.BenhNhan_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public virtual async Task<DM_BenhNhan> GetByBenhNhan_IdAsync(int BenhNhan_Id)
        {
            DM_BenhNhan result = new DM_BenhNhan();
            if (BenhNhan_Id > 0)
            {
                result = await GetByCondition(item => item.BenhNhan_Id == BenhNhan_Id).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new DM_BenhNhan();
            }
            return result;
        }
        public virtual async Task<DM_BenhNhan> GetBySearchStringAsync(string SearchString)
        {
            DM_BenhNhan result = new DM_BenhNhan();
            if (!string.IsNullOrEmpty(SearchString))
            {
                SearchString = SearchString.Trim();
                result = await GetByCondition(item => item.MaYTe.Trim().Contains(SearchString)).FirstOrDefaultAsync();
                if (result == null)
                {
                    result = await GetByCondition(item => item.CMND.Trim() == SearchString).FirstOrDefaultAsync();
                }
            }
            if (result == null)
            {
                result = new DM_BenhNhan();
            }
            return result;
        }
        public override async Task<List<DM_BenhNhan>> GetBySearchStringToListAsync(string searchString)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                result = await GetByCondition(item => item.BenhNhan_Id.ToString() == searchString).ToListAsync();
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.MaYTe.Contains(searchString)).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.CMND.Trim() == searchString).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.SoDienThoai.Trim() == searchString).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.SoBHXH.Trim() == searchString).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.TenBenhNhan.Trim() == searchString).ToListAsync();
                }
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(60).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_BenhNhan>();
            }
            return result;
        }
        public virtual async Task<List<DM_BenhNhan>> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            if (!string.IsNullOrEmpty(searchString))
            {
                result = await GetBySearchStringToListAsync(searchString);
            }
            else
            {
                if (XaPhuong_Id > 0)
                {
                    result = await GetByCondition(item => item.XaPhuong_Id == XaPhuong_Id).ToListAsync();
                }
                else
                {
                    if (QuanHuyen_Id > 0)
                    {
                        result = await GetByCondition(item => item.QuanHuyen_Id == QuanHuyen_Id).ToListAsync();
                    }
                    else
                    {
                        if (TinhThanh_Id > 0)
                        {
                            result = await GetByCondition(item => item.TinhThanh_Id == TinhThanh_Id).ToListAsync();
                        }
                    }
                }
            }
            if (result == null)
            {
                result = new List<DM_BenhNhan>();
            }
            if (result.Count == 0)
            {
                result = await GetByCondition(item => 1 == 1).Take(60).ToListAsync();
            }
            return result;
        }
        public virtual async Task<List<DM_BenhNhan>> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToListAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString, int Page)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            if (!string.IsNullOrEmpty(searchString))
            {
                result = await GetBySearchStringToListAsync(searchString);
            }
            else
            {
                if (XaPhuong_Id > 0)
                {
                    result = await GetByCondition(item => item.XaPhuong_Id == XaPhuong_Id).ToListAsync();
                }
                else
                {
                    if (QuanHuyen_Id > 0)
                    {
                        result = await GetByCondition(item => item.QuanHuyen_Id == QuanHuyen_Id).ToListAsync();
                    }
                    else
                    {
                        if (TinhThanh_Id > 0)
                        {
                            result = await GetByCondition(item => item.TinhThanh_Id == TinhThanh_Id).ToListAsync();
                        }
                    }
                }
            }
            if (result == null)
            {
                result = new List<DM_BenhNhan>();
            }
            int PageCount = 0;
            if (result.Count == 0)
            {
                result = await GetByCondition(item => 1 == 1).Take(60).ToListAsync();
            }
            else
            {
                if (result.Count > GlobalHelper.APIDataLimit)
                {
                    PageCount = result.Count / GlobalHelper.APIDataLimit;
                }
                result = result.Skip(Page * GlobalHelper.APIDataLimit).Take(GlobalHelper.APIDataLimit).ToList();
            }
            result[0].NguoiTao_Id = PageCount;
            return result;
        }
        public virtual async Task<int> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToCountAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            result = await GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync(TinhThanh_Id, QuanHuyen_Id, XaPhuong_Id, searchString);
            int PageCount = 0;
            if (result.Count > 0)
            {
                if (result.Count > GlobalHelper.APIDataLimit)
                {
                    PageCount = result.Count / GlobalHelper.APIDataLimit;
                }
            }
            return PageCount;
        }
        public virtual async Task<List<DM_BenhNhan>> GetByListIDToListAsync(List<int> ListID)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.BenhNhan_Id)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_BenhNhan>();
            }
            return result;
        }
    }
}

