import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhi } from './XacNhanChiPhi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanChiPhi_Id', 'SoXacNhan', 'TiepNhan_Id', 'BenhAn_Id', 'KhamBenh_Id', 'BenhNhan_Id', 'DoiTuong_Id', 'SoBHYT', 'NgayVao', 'NgayRa', 'NgayKham', 'ChanDoan', 'Loai', 'NgayXacNhan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BenhVien_id', 'IDChuyen', 'IDChuyenHuy', 'IDChuyenHoan', 'TuyenKhamBenh', 'ThoiGianXacNhan', 'NgayXuatThuoc', 'NoiXacNhan_ID', 'MaBenh', 'BenhKhac', 'TenPhongKham', 'Center_XN_ID', 'Center_ThoiGianChuyen', 'OtherSite_XacNhanChiPhi_ID', 'Export', 'Export_CV130'];

    List: XacNhanChiPhi[] | undefined;
    ListFilter: XacNhanChiPhi[] | undefined;
    FormData!: XacNhanChiPhi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhi";
    }
}

