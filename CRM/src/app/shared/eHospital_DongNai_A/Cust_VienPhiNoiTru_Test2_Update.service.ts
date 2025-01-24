import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cust_VienPhiNoiTru_Test2_Update } from './Cust_VienPhiNoiTru_Test2_Update.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cust_VienPhiNoiTru_Test2_UpdateService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'VienPhiNoiTru_Id', 'SoChungTu', 'LoaiChungTu', 'BenhAn_Id', 'LuuTru_Id', 'PhatSinh_Noi_Id', 'PhatSinh_Nguoi_Id', 'PhatSinh_Ngay', 'PhatSinh_ThoiGian', 'Tra_Ngay', 'Tra_ThoiGian', 'Tra_Noi_Id', 'Tra_Nguoi_Id', 'ThuTien_Noi_Id', 'ThuTien_Nguoi_Id', 'ThuTien_Ngay', 'ThuTien_ThoiGian', 'Huy_Noi_Id', 'Huy_Nguoi_Id', 'Huy_Ngay', 'Huy_ThoiGian', 'DaThanhToan', 'HuyHoaDon', 'HoanTra', 'GiaTriHoaDon', 'TyleMienGiam', 'GiaTriMienGiam', 'TyLeThatThu', 'GiaTriThatThu', 'LoaiTien_Id', 'TyGia', 'TyLeVAT', 'GiaTriVAT', 'HinhThucThanhToan_Id', 'HoaDonLienQuan_Id', 'DangKyHoaDon_Id', 'SoSerieVAT', 'SoHoaDonVAT', 'GhiChu', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'IDChuyen', 'Status', 'Transfer_VienPhi_Id', 'DoiTuong_Id', 'InLai_TamUng', 'InLai_HoanUng', 'InLai_BienLaiTaiChinh', 'InLai_User_Id', 'IDChuyenHuy', 'IDChuyenHoan', 'ThuHD_BL', 'TenCongTy', 'MaSoThue', 'DiaChiCongTy', 'ChuyenChungTuID', 'ChuyenChungTuHoanID', 'ChuyenChungTuHuyID', 'ChuyenDoanhThuID', 'ChuyenDoanhThuHoanID', 'ChuyenDoanhThuHuyID', 'ChungTuDoiUng', 'OtherSite_VienPhiNoiTru_Id', 'SiteCode', 'DaChuyenKhu'];

    List: Cust_VienPhiNoiTru_Test2_Update[] | undefined;
    ListFilter: Cust_VienPhiNoiTru_Test2_Update[] | undefined;
    FormData!: Cust_VienPhiNoiTru_Test2_Update;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cust_VienPhiNoiTru_Test2_Update";
    }
}

