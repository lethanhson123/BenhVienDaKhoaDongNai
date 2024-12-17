namespace Service.Implement
{
    public class DanhMucTinhThanhToaDoService : BaseService<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoRepository>
    , IDanhMucTinhThanhToaDoService
    {
        private readonly IDanhMucTinhThanhToaDoRepository _DanhMucTinhThanhToaDoRepository;
        public DanhMucTinhThanhToaDoService(IDanhMucTinhThanhToaDoRepository DanhMucTinhThanhToaDoRepository) : base(DanhMucTinhThanhToaDoRepository)
        {
            _DanhMucTinhThanhToaDoRepository = DanhMucTinhThanhToaDoRepository;
        }
        public virtual async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync(long ParentID, bool Active)
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            if (ParentID>0)
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
    }
}

