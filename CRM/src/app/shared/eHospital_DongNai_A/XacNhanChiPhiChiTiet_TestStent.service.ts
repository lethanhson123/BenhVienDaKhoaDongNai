import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhiChiTiet_TestStent } from './XacNhanChiPhiChiTiet_TestStent.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhiChiTiet_TestStentService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanChiPhiChiTiet_Id', 'XacNhanChiPhi_Id', 'Loai_IDRef', 'IDRef', 'NoiDung_Id', 'NoiDung', 'SoLuong', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'SoLuong_New', 'DonGiaHoTroChiTra_New', 'Loai', 'NgayCapNhat', 'NguoiCapNhat_Id', 'PhongBan_Id', 'NgoaiTru_ToaThuoc_ID', 'NoiTru_ToaThuoc_ID', 'SiteCode_PhatSinh', 'TenDonViTinh', 'Center_XN_ChiTiet_ID', 'XN_DonGiaVon', 'XN_DonGiaMua', 'Tyle_TT', 'Muc_Huong', 'Ma_Khoa', 'Ma_Bac_Si', 'Ngay_YL', 'Ngay_KQ', 'Ma_PTTT', 'Ma_Giuong', 'BacSi_Id'];

    List: XacNhanChiPhiChiTiet_TestStent[] | undefined;
    ListFilter: XacNhanChiPhiChiTiet_TestStent[] | undefined;
    FormData!: XacNhanChiPhiChiTiet_TestStent;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhiChiTiet_TestStent";
    }
}

