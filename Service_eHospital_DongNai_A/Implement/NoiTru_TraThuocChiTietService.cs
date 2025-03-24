namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_TraThuocChiTietService : BaseService<NoiTru_TraThuocChiTiet, INoiTru_TraThuocChiTietRepository>
    , INoiTru_TraThuocChiTietService
    {
        private readonly INoiTru_TraThuocChiTietRepository _NoiTru_TraThuocChiTietRepository;
        public NoiTru_TraThuocChiTietService(INoiTru_TraThuocChiTietRepository NoiTru_TraThuocChiTietRepository) : base(NoiTru_TraThuocChiTietRepository)
        {
            _NoiTru_TraThuocChiTietRepository = NoiTru_TraThuocChiTietRepository;
        }
        public virtual async Task<List<NoiTru_TraThuocChiTiet>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_TraThuocChiTiet> result = new List<NoiTru_TraThuocChiTiet>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.NoiTru_TraThuoc_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_TraThuocChiTiet>();
            }
            return result;
        }
    }
}

