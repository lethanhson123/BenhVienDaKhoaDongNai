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
        public override async Task<List<DM_BenhNhan>> GetBySearchStringToListAsync(string searchString)
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                result = await GetByCondition(item => item.MaYTe.Contains(searchString)).ToListAsync();                
                if (result == null)
                {
                    result = await GetByCondition(item => item.CMND.Contains(searchString)).ToListAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.SoDienThoai.Contains(searchString)).ToListAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.TenBenhNhan.Contains(searchString)).ToListAsync();
                }
                if (result == null)
                {
                    result = await GetByCondition(item => item.BenhNhan_Id.Value.ToString().Contains(searchString)).ToListAsync();
                }
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(19).ToListAsync();
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
                result = await GetByCondition(item => 1 == 1).Take(20).ToListAsync();
            }
            return result;
        }
    }
}

