import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThuPhanUngThuoc } from './ThuPhanUngThuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThuPhanUngThuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhanUngThuoc_Id', 'SoPhieu', 'BenhAn_Id', 'LuuTru_Id', 'NgayThucHien', 'ThoiGianThucHien', 'ChanDoan', 'KetQua', 'DuongTinh', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'PhuongPhapThu_Id', 'NguoiThucHien_Id', 'BacSiKiemTra_Id', 'Duoc_Id', 'SoLo', 'SoSanXuat', 'BacSiChiDinh_Id', 'NgayDocKetQua', 'ThoiGianDocKetQua', 'AmTinh'];

    List: ThuPhanUngThuoc[] | undefined;
    ListFilter: ThuPhanUngThuoc[] | undefined;
    FormData!: ThuPhanUngThuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThuPhanUngThuoc";
    }
}

