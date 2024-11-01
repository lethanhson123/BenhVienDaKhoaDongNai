namespace Service.Interface
{
    public interface IDuAnQuyetToanLuyKeService : IBaseService<DuAnQuyetToanLuyKe>
    {
        Task<List<DuAnQuyetToanLuyKe>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh);
    }
}

