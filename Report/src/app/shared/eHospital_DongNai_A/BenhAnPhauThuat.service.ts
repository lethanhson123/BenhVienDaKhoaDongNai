import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat } from './BenhAnPhauThuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_Id', 'CLSYeuCau_Id', 'SoPhieuPhauThuat', 'Loai', 'BenhAn_Id', 'LuuTru_Id', 'TiepNhan_Id', 'PhongBanThucHien_Id', 'NgayThucHien', 'ThoiGianBatDau', 'ThoiGianKetThuc', 'ICD_VaoKhoa', 'ICD_TruocPhauThuat', 'ICD_TruocPhauThuat_MoTa', 'ICD_SauPhauThuat', 'ICD_SauPhauThuat_MoTa', 'NhomDichVu_Id', 'DichVu_Id', 'PhuongPhapVoCam_Id', 'TaiBien_Id', 'CheDo_Id', 'TuVong_Id', 'TrinhTuThucHien', 'MoTa', 'KetQua', 'BenhNhanBenNgoai', 'NguonBenh_Id', 'LoaiPhauThuat', 'DanLuu', 'NgayRut', 'NgayCatChi', 'Khac', 'MoLai', 'CanThiepPhauThuat', 'TuDienKetQua_Id', 'LoaiGia_Id', 'DonGiaDoanhThu', 'DonGiaThanhToan', 'LoaiTien_Id', 'TyGia', 'TyLeMienGiam', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KhoaDuLieu', 'NgayKhoaDuLieu', 'ThoiGianKhoaDuLieu', 'NguoiKhoa_Id', 'TenNguoiKhoa', 'PhongBanChiDinh_id', 'PPMo_Id', 'ThoiGianGayMe', 'TrinhTuThucHien_Text'];

    List: BenhAnPhauThuat[] | undefined;
    ListFilter: BenhAnPhauThuat[] | undefined;
    FormData!: BenhAnPhauThuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat";
    }
}

