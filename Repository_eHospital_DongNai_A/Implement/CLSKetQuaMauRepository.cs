﻿namespace Repository_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaMauRepository : BaseRepository<CLSKetQuaMau>
    , ICLSKetQuaMauRepository
    {
    private readonly Context _context;
    public CLSKetQuaMauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

