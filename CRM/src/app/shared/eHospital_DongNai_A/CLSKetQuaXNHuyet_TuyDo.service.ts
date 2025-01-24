import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQuaXNHuyet_TuyDo } from './CLSKetQuaXNHuyet_TuyDo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQuaXNHuyet_TuyDoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ClsKetQuaXNHuyet_TuyDo_Id', 'CLSYeuCau_Id', 'MaSoPhieu', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'BacSiChiDinh_Id', 'BacSiKetLuan_Id', 'KyThuatVien_Id', 'NgayGioThucHien', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'LamTuy', 'LamMau', 'MauCheckList_Id', 'HoaTeBao', 'KetLuan', 'DeNghi', 'NoiThucHien_Id', 'DichVu_Id', 'YeuCauChiTiet_Id', 'ClsKetQua_Id', 'NgayThucHien'];

    List: CLSKetQuaXNHuyet_TuyDo[] | undefined;
    ListFilter: CLSKetQuaXNHuyet_TuyDo[] | undefined;
    FormData!: CLSKetQuaXNHuyet_TuyDo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQuaXNHuyet_TuyDo";
    }
}

