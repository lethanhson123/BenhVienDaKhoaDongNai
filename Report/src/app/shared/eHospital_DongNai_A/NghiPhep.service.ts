import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NghiPhep } from './NghiPhep.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NghiPhepService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NghiPhep_Id', 'SoPhieu', 'BenhNhan_Id', 'TiepNhan_Id', 'KhamBenh_Id', 'BenhAnNoiTru_Id', 'BenhAnNgoaiTru_Id', 'BacSiYeuCau_Id', 'BacSiTruongKhoa_Id', 'LyDoNghiPhep_Id', 'SoNgayNghi', 'ChanDoanICD_Id', 'ChanDoan', 'GhiChu', 'NgayRaPhieu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'DonViLamViec', 'SoSeri', 'SoBHXH', 'HoTenCha', 'HoTenMe', 'SoBHYT'];

    List: NghiPhep[] | undefined;
    ListFilter: NghiPhep[] | undefined;
    FormData!: NghiPhep;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NghiPhep";
    }
}

