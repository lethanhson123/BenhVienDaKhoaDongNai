import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSKetQua_Version } from './CLSKetQua_Version.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSKetQua_VersionService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSKetQua_Version_Id', 'CLSKetQua_Id', 'CLSYeuCau_Id', 'NgayThucHien', 'ThoiGianThucHien', 'NgayGioThucHien', 'GioThucHien', 'NamThucHien', 'ThangThucHien', 'NoiThucHien_Id', 'BacSiThucHien_Id', 'KyThuatVien01_Id', 'KyThuatVien02_Id', 'BacSiKetLuan_Id', 'ThucHienBenNgoai', 'BenhVienThucHien_Id', 'TenBacSiBenNgoai', 'VungKhaoSat', 'MoTa', 'MoTa_Text', 'KetLuan', 'GhiChu', 'NhomDichVu_Id', 'MaPhim', 'TiemCanQuang', 'SoPhimSuDung', 'SoThuocSuDung', 'SinhThiet', 'Clotest', 'Photo', 'Video', 'Mach', 'HuyetAp', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'BSA', 'ThietBi_Id', 'PhanLoaiKetQua_Id', 'KhoaDuLieu', 'NgayKhoaDuLieu', 'ThoiGianKhoaDuLieu', 'NguoiKhoa_Id', 'MaNguoiKhoa', 'TenNguoiKhoa', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TinhTrangDienNao', 'GPB_AmSo', 'GPB_PhanLoaiKetQua_Id', 'GPB_PhuongPhapLayBenhPham_Id', 'GPB_SoMau', 'GPB_SoLuongMau', 'GPB_Topo_Id', 'GPB_TopoRegions_Id', 'GPB_Morpho_Id', 'GPB_Etio_Id', 'GPB_DaiThe', 'GPB_ViThe', 'GPB_Nhuom_HE', 'GPB_Nhuom_PAS', 'GPB_Nhuom_Tri', 'GPB_Nhuom_AFB', 'GPB_Nhuom_Giemsa', 'GPB_Nhuom_Other', 'GPB_HoaMienDich', 'GPB_HoaMienDichHuynhQuang', 'GPB_HoiChan', 'SoVaoVien', 'MaYTe', 'TenBenhNhan', 'NamSinh', 'GioiTinh', 'DiaChi', 'NoiChiDinh_Id', 'BacSiChiDinh', 'NgayChiDinh', 'MauThu_Id', 'ThoiGiannhan', 'Mau', 'DeNghi'];

    List: CLSKetQua_Version[] | undefined;
    ListFilter: CLSKetQua_Version[] | undefined;
    FormData!: CLSKetQua_Version;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSKetQua_Version";
    }
}

