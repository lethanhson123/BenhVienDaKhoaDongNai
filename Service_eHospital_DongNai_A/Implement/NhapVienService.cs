namespace Service_eHospital_DongNai_A.Implement
{
    public class NhapVienService : BaseService<NhapVien, INhapVienRepository>
    , INhapVienService
    {
        private readonly INhapVienRepository _NhapVienRepository;
        public NhapVienService(INhapVienRepository NhapVienRepository) : base(NhapVienRepository)
        {
            _NhapVienRepository = NhapVienRepository;
        }
        public virtual async Task<List<NhapVien>> GetByListIDToListAsync(List<int?> ListID)
        {
            List<NhapVien> result = new List<NhapVien>();
            if (ListID.Count > 0)
            {
                result = await GetByCondition(item => EF.Constant(ListID).Contains(item.TiepNhan_Id.Value)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<NhapVien>();
            }
            return result;
        }
    }
}

