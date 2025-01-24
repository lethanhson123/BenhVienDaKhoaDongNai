import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_GiamGiaTheoTG } from './CSKH_The_GiamGiaTheoTG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_GiamGiaTheoTGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_GiamGiaTheoTG_Id', 'The_Id', 'LoaiKhachHang_Id', 'The_DSDoiTuongKM_Id', 'DichVu_Id', 'TyLe', 'ThoiGianMin', 'ThoiGianMax', 'SoNgay', 'TatCaDichVu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_GiamGiaTheoTG[] | undefined;
    ListFilter: CSKH_The_GiamGiaTheoTG[] | undefined;
    FormData!: CSKH_The_GiamGiaTheoTG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_GiamGiaTheoTG";
    }
}

