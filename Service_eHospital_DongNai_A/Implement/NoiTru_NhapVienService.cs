namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_NhapVienService : BaseService<NoiTru_NhapVien, INoiTru_NhapVienRepository>
    , INoiTru_NhapVienService
    {
        private readonly INoiTru_NhapVienRepository _NoiTru_NhapVienRepository;
        public NoiTru_NhapVienService(INoiTru_NhapVienRepository NoiTru_NhapVienRepository) : base(NoiTru_NhapVienRepository)
        {
            _NoiTru_NhapVienRepository = NoiTru_NhapVienRepository;
        }
        public virtual async Task<List<NoiTru_NhapVien>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NoiTru_NhapVien> result = new List<NoiTru_NhapVien>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.TiepNhan_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NoiTru_NhapVien>();
            }
            return result;
        }
    }
}

