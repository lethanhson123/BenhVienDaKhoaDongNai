namespace Service.Interface
{
    public interface IDuAnQuyetToanPhanKyService : IBaseService<DuAnQuyetToanPhanKy>
    {
        Task<List<DuAnQuyetToanPhanKy>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh);
    }
}

