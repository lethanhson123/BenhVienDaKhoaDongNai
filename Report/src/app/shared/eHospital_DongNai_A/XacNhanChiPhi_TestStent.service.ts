import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhi_TestStent } from './XacNhanChiPhi_TestStent.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhi_TestStentService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanChiPhi_Id', 'SoXacNhan', 'TiepNhan_Id', 'BenhAn_Id', 'KhamBenh_Id', 'BenhNhan_Id', 'DoiTuong_Id', 'SoBHYT', 'NgayVao', 'NgayRa', 'NgayKham', 'ChanDoan', 'Loai', 'NgayXacNhan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BenhVien_id', 'IDChuyen', 'IDChuyenHuy', 'IDChuyenHoan', 'TuyenKhamBenh', 'ThoiGianXacNhan', 'NgayXuatThuoc', 'NoiXacNhan_ID', 'MaBenh', 'BenhKhac', 'TenPhongKham', 'Center_XN_ID', 'Center_ThoiGianChuyen', 'OtherSite_XacNhanChiPhi_ID', 'Export'];

    List: XacNhanChiPhi_TestStent[] | undefined;
    ListFilter: XacNhanChiPhi_TestStent[] | undefined;
    FormData!: XacNhanChiPhi_TestStent;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhi_TestStent";
    }
}

