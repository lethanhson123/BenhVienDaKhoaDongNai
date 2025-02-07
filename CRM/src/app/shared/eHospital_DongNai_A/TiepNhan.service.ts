import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhan } from './TiepNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhan_Id', 'SoTiepNhan', 'SoThuTu', 'UuTien', 'BenhNhan_Id', 'NoiTiepNhan_Id', 'NgayTiepNhan', 'ThoiGianTiepNhan', 'NamTiepNhan', 'ThangTiepNhan', 'DoiTuong_Id', 'NoiLamViec', 'NguoiLienHe_Id', 'NguoiLienHe', 'DiaChiLienHe', 'HinhThucDenKham_Id', 'NoiGioiThieu_Id', 'LyDoTiepNhan_Id', 'SoBHYT', 'BHYTTuNgay', 'BHYTDenNgay', 'ThuTienTruoc', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ChanDoanNGT', 'TaiKham', 'DonViCongTac_Id', 'PhieuDieuTri_Id', 'TuyenKhamBenh_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'LoaiBHYT', 'DoiTuong_ChiTiet_Id', 'BenhVien_KCB_Id', 'NgayBHYT1', 'NgayBHYT2', 'NgayBHYT3', 'XacNhanChiPhi_Id', 'SoChuyenVien', 'HinhThucChuyenVien_Id', 'LyDoChuyenVien_Id', 'HopDong_BenhNhan_Id', 'HinhThucThanhToan_Id', 'TienSuBenh', 'ThoiGianChuyenTuyen', 'TrungSoBHYT', 'Tren6Thang', 'ThuocUngThu', 'CongTyBHTN_ID', 'SoTheBHTN', 'BHTN_TuNgay', 'BHTN_DenNgay', 'BHTN_DiaChi', 'BHTN_DienThoai', 'BHTN_Fax', 'SiteCode', 'Mapping_Public_Id', 'IsDiffSite', 'The_ID', 'LoaiKhachHang_ID', 'KhongCungChiTra', 'NoiSinhSong_ID', 'TongTienHoTro', 'HieuLucTuNgay', 'HieuLucDenNgay', 'NgayHuong5Nam', 'DaXuatHSKSK', 'Export', 'NguoiGioiThieu_Id'];
    DisplayColumns002: string[] = ['STT', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TiepNhan_Id', 'ThoiGianTiepNhan', 'SoThuTu', 'NoiTiepNhan', 'BenhNhan_Id', 'UuTien', 'TaiKham', 'ThuTienTruoc', 'DoiTuong_Id', 'SoBHYT', 'BenhVien_KCB_Id', 'HinhThucDenKham_Id', 'LyDoTiepNhan_Id', 'TuyenKhamBenh_Id', 'HinhThucChuyenVien_Id', 'LyDoChuyenVien_Id', 'ThoiGianChuyenTuyen', 'SoChuyenVien', 'TienSuBenh', 'NguoiLienHe', 'DiaChiLienHe'];
    List: TiepNhan[] | undefined;
    ListFilter: TiepNhan[] | undefined;
    FormData!: TiepNhan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhan";
    }
    GetByBenhAn_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByBenhAn_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByNgayTiepNhan_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByNgayTiepNhan_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

