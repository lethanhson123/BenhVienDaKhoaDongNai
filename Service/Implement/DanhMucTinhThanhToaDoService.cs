namespace Service.Implement
{
    public class DanhMucTinhThanhToaDoService : BaseService<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoRepository>
    , IDanhMucTinhThanhToaDoService
    {
        private readonly IDanhMucTinhThanhToaDoRepository _DanhMucTinhThanhToaDoRepository;

        private readonly IDanhMucXaPhuongRepository _DanhMucXaPhuongRepository;

        private readonly IDanhMucQuanHuyenRepository _DanhMucQuanHuyenRepository;
        public DanhMucTinhThanhToaDoService(IDanhMucTinhThanhToaDoRepository DanhMucTinhThanhToaDoRepository

            , IDanhMucXaPhuongRepository DanhMucXaPhuongRepository

            , IDanhMucQuanHuyenRepository DanhMucQuanHuyenRepository

            ) : base(DanhMucTinhThanhToaDoRepository)
        {
            _DanhMucTinhThanhToaDoRepository = DanhMucTinhThanhToaDoRepository;

            _DanhMucXaPhuongRepository = DanhMucXaPhuongRepository;
            _DanhMucQuanHuyenRepository = DanhMucQuanHuyenRepository;
        }
        public virtual async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync(long ParentID, bool Active)
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            if (ParentID > 0)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ParentID",ParentID),
                    new SqlParameter("@Active",Active),
                };
                result = await GetByStoredProcedureToListAsync("sp_DanhMucTinhThanhToaDoSelectItemsDanhMucQuanHuyenByParentID_Active", parameters);
            }
            return result;
        }
        public virtual async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync(long ParentID, bool Active)
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            if (ParentID > 0)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@ParentID",ParentID),
                    new SqlParameter("@Active",Active),
                };
                result = await GetByStoredProcedureToListAsync("sp_DanhMucTinhThanhToaDoSelectItemsDanhMucXaPhuongByParentID_Active", parameters);
            }
            return result;
        }
        public virtual async Task<List<DanhMucTinhThanhToaDo>> GetByParentID_Active_NumberToListAsync(long ParentID, bool Active, int Number)
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            if (ParentID > 0)
            {
                List<long> ListParentID = new List<long>();
                if (Number % 2 == 0)
                {
                    List<DanhMucQuanHuyen> ListDanhMucQuanHuyen = await _DanhMucQuanHuyenRepository.GetByParentIDAndActiveToListAsync(ParentID, Active);
                    if (ListDanhMucQuanHuyen.Count > 0)
                    {
                        ListParentID= ListDanhMucQuanHuyen.Select(x => x.ID).ToList();
                    }
                }
                else
                {
                    List<DanhMucXaPhuong> ListDanhMucXaPhuong = await _DanhMucXaPhuongRepository.GetByParentIDAndActiveToListAsync(ParentID, Active);
                    if (ListDanhMucXaPhuong.Count > 0)
                    {
                        ListParentID = ListDanhMucXaPhuong.Select(x => x.ID).ToList();
                    }
                }
                if (ListParentID.Count > 0)
                {
                    result = await GetByCondition(item => ListParentID.Contains(item.ParentID.Value) && item.Active == Active).ToListAsync();
                }
            }
            return result;
        }
    }
}

