import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NHANVIEN } from './NS_NHANVIEN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NHANVIENService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNhanVien', 'Ho', 'Ten', 'HinhAnh', 'NgaySinh', 'NoiSinh', 'GioiTinh', 'MaDanToc', 'MaQuocTich', 'MaTonGiao', 'Quequan', 'DiaChihokhau', 'DiaChiLienhe', 'Passport', 'SoTaikhoan', 'Nganhang', 'SoBHXH', 'BHXHTuNgay', 'BHXHDenNgay', 'SoBHYT', 'BHYTTuNgay', 'BHYTDenNgay', 'MaUngvien', 'MaTrinhDo', 'ChuyenMon', 'NgayThuViec', 'NgayHetThuViec', 'NgayThamGiaCM', 'NgayVaoDoan', 'NgayVaoDang', 'MaChucVu', 'MaChucDanh', 'SucKhoe', 'ChieuCao', 'CanNang', 'NhomMau', 'DienThoai', 'Email', 'CMND', 'NoiCap', 'NgayCap', 'HonNhan', 'NgayVaoLam', 'NgayNghiViec', 'MaPhongBan', 'DangLamViec', 'MaNhom', 'Didong', 'Nangkhieu', 'Ghichu', 'Congviec', 'ID', 'SoSLD', 'SLDCapNgay', 'SoQuyetDinh', 'TienTroCap', 'LyDoNghi', 'Dutru1', 'Dutru2', 'Dutru3', 'Dutru4', 'Dutru5', 'MaSoThue', 'NamVaoNganhDauKhi', 'ChungChiTinHoc', 'TinhThanh', 'SapXep', 'MaHopDong', 'MaTrinhDoQuanLyNN', 'NgayQuyetDinhNghiViec', 'DangVien', 'MaTrinhDoChinhTri', 'MaChucVu_BaoCao', 'NhanVien_Id', 'MocTinhPhep', 'TenKhongDau', 'Trai_Id', 'SapXep_Trai'];
    DisplayColumns002: string[] = ['STT', 'NhanVien_Id', 'MaNhanVien', 'Ho', 'Ten','DangLamViec','DangVien', 'Didong','MaTrinhDo','ChuyenMon','MaChucVu','MaChucDanh','MaPhongBan','SoBHXH','MaSoThue','MaHopDong','CMND','NgayCap', 'NgaySinh','NgayThuViec','NgayVaoLam','NgayThamGiaCM','NgayVaoDoan','NgayVaoDang','NgayNghiViec', 'LyDoNghi','GioiTinh', 'SoTaikhoan', 'Nganhang', 'Email', 'DiaChiLienhe'];
    DisplayColumns003: string[] = ['STT', 'NhanVien_Id', 'MaNhanVien', 'HoTen', 'DangLamViec','DangVien', 'Didong','MaTrinhDo','ChuyenMon','MaChucVu','MaChucDanh','MaPhongBan','SoBHXH','MaSoThue','MaHopDong','CMND','NgayCap', 'NgaySinh','NgayThuViec','NgayVaoLam','NgayThamGiaCM','NgayVaoDoan','NgayVaoDang','NgayNghiViec', 'LyDoNghi','GioiTinh', 'SoTaikhoan', 'Nganhang', 'Email', 'DiaChiLienhe'];
    List: NS_NHANVIEN[] | undefined;
    ListFilter: NS_NHANVIEN[] | undefined;
    FormData!: NS_NHANVIEN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NHANVIEN";
    }
    GetByNhanVien_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByNhanVien_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByMaNhanVienAsync() {
        let url = this.APIURL + this.Controller + '/GetByMaNhanVienAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

