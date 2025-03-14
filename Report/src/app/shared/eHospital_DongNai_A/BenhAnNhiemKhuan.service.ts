import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnNhiemKhuan } from './BenhAnNhiemKhuan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnNhiemKhuanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnNhiemKhuan_Id', 'BenhAn_Id', 'Ngay', 'NhiemKhuanTT_Id', 'NhiemKhuanBV_Id', 'LoaiThuThuat_Id', 'TacNhan', 'LyDoNhiemKhuan_Id', 'PhuongPhapDieuTri', 'LoiDanThayThuoc', 'ChanDoanRaVien', 'Attribute_1', 'Attribute_2', 'Attribute_3', 'Attribute_4'];

    List: BenhAnNhiemKhuan[] | undefined;
    ListFilter: BenhAnNhiemKhuan[] | undefined;
    FormData!: BenhAnNhiemKhuan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnNhiemKhuan";
    }
}

