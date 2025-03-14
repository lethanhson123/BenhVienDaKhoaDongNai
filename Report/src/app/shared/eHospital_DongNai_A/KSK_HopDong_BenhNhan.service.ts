import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong_BenhNhan } from './KSK_HopDong_BenhNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDong_BenhNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Id', 'HopDong_id', 'Benhnhan_ehos_id', 'MaYTe', 'STT', 'TenBenhNhan', 'Ho', 'Ten', 'GioiTinh', 'NgaySinh', 'NamSinh', 'DiaChi', 'NhomMau_Id', 'YeuToRH_Id', 'TienSuDiUng', 'SoLuuTruNgoaiTru', 'SoLuuTruNoiTru', 'TuVong', 'GhiChu', 'QuocTich_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'DanToc_Id', 'NgheNghiep_Id', 'CMND', 'HoChieu', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoDienThoai', 'KetQua', 'NgayCapThe', 'NamCapThe', 'NhanVien_Id', 'TienSuBenh', 'TienSuHutThuocLa', 'DonViCongTac_Id', 'SoDienThoai1', 'NgayTiepNhanGanNhat', 'ThoiGianTiepNhanGanNhat', 'Xeploai_id', 'bsketluan_id', 'tinhtranghonnhan_id', 'NhomDoiTuong_Id', 'ChuyenChungTuID', 'ChuyenChungTu_HoaDonID', 'IDChuyen', 'NgayHen', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'BMI', 'Mat_KhongKinh_Phai', 'Mat_KhongKinh_Trai', 'Mat_CoKinh_Phai', 'Mat_CoKinh_Trai', 'Mat_CacBenhVeMat', 'TMH_TaiTrai_NoiThuong', 'TMH_TaiTrai_NoiTham', 'TMH_TaiPhai_NoiThuong', 'TMH_TaiPhai_NoiTham', 'TMH_CacBenhVeTMH', 'RHM_HamTren', 'RHM_HamDuoi', 'RHM_CacBenhVeRHM', 'MaNhanVien', 'DonVi_BoPhan'];

    List: KSK_HopDong_BenhNhan[] | undefined;
    ListFilter: KSK_HopDong_BenhNhan[] | undefined;
    FormData!: KSK_HopDong_BenhNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong_BenhNhan";
    }
}

