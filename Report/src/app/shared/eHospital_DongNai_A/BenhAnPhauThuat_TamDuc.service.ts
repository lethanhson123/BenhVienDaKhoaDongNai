import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat_TamDuc } from './BenhAnPhauThuat_TamDuc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuat_TamDucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_Id', 'CLSYeuCau_Id', 'TiepNhan_Id', 'BenhAn_Id', 'LuuTru_Id', 'SoPhieuPhauThuat', 'Loai', 'PhanNhom_Id', 'Loai_Id', 'ChanDoan_Id', 'NgayThucHien', 'ThoiGianBatDau', 'ThoiGianKetThuc', 'ICD_VaoKhoa', 'ICD_VaoKhoa_MoTa', 'ICD_TruocPhauThuat', 'ICD_TruocPhauThuat_MoTa', 'ICD_SauPhauThuat', 'ICD_SauPhauThuat_MoTa', 'DichVu_Id', 'PhuongPhap_Id', 'PhuongPhapVoCam_Id', 'TaiBien_Id', 'CheDo_Id', 'TuVong_Id', 'TrinhTuThucHien', 'MoTa', 'KetQua', 'LoaiGia_Id', 'DonGiaPhaiThu', 'TyleVAT', 'GiaTriVAT', 'SoTien', 'LoaiTien_Id', 'TyGia', 'BenhNhanBenNgoai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NguonBenh_Id', 'PhongBanThucHien_Id', 'DanLuu', 'NgayRut', 'NgayCatChi', 'Khac', 'KyThuat_Id', 'GhiChu', 'TuDienKetQua_Id', 'MoLai'];

    List: BenhAnPhauThuat_TamDuc[] | undefined;
    ListFilter: BenhAnPhauThuat_TamDuc[] | undefined;
    FormData!: BenhAnPhauThuat_TamDuc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat_TamDuc";
    }
}

