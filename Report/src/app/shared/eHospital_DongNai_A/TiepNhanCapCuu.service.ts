import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhanCapCuu } from './TiepNhanCapCuu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhanCapCuuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhanCapCuu_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'NoiLamViec', 'DienThoaiNLV', 'NguoiThan', 'DienThoaiNT', 'NoiDuaDen', 'DienThoaiNDD', 'NgayTaiNan', 'ThoiGianTaiNan', 'NgayCapCuu', 'ThoiGianCapCuu', 'NgayKhamBenh', 'ThoiGianKhamBenh', 'NoiBiTaiNan_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'PhuongXa_Id', 'DiaChi', 'DienBienSauTN_Id', 'NguyenNhan_Id', 'NguyenNhan_ICD', 'NguyenNhanChiTiet_Id', 'ThuongTich_Id', 'MucDo_Id', 'ChiTietCapCuu', 'NgayRa', 'ThoiGianRa', 'HoiChan', 'TinhHinhXuat', 'SoNgayNghi', 'MatSuc', 'KhoaNhap_Id', 'ChuyenVien_Id', 'BenhSu', 'Mach', 'NhipTho', 'NhietDo', 'CanNang', 'HuyetAp', 'HuyetApCao', 'HuyetApThap', 'ChieuCao', 'KetQuaDieuTri_Id', 'NhapKhoa_Id', 'TienSuBenh', 'CanLamSang', 'ChanDoanLucVao', 'ICD_Vao_Id', 'ChanDoanLucRa', 'ICD_Ra_Id', 'XuTri', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TuVong', 'NgayTuVong', 'ThoiGianTuVong', 'ThoiGianKhamNghiem', 'ThoiGianNhanTuThi', 'KetQuaKhamNghiem', 'GhiChu', 'ICD_TuVong_Id', 'BacSiGhiNhanTuVong_Id', 'BacSiKhamNghiem_Id'];

    List: TiepNhanCapCuu[] | undefined;
    ListFilter: TiepNhanCapCuu[] | undefined;
    FormData!: TiepNhanCapCuu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhanCapCuu";
    }
}

