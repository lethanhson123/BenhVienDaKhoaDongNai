﻿namespace Service.Interface
{
    public interface IDuAnThuChiService : IBaseService<DuAnThuChi>
    {
        Task<List<DuAnThuChi>> GetSQLByCodeToListAsync(string Code);
        Task<List<DuAnThuChi>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh);
    }
}

