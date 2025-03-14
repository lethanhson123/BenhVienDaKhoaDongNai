import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChuyenVien } from './ChuyenVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChuyenVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChuyenVien_Id', 'SoPhieu', 'BenhNhan_Id', 'TiepNhan_Id', 'KhamBenh_Id', 'BenhAnNoiTru_Id', 'BenhAnNgoaiTru_Id', 'BacSiYeuCau_Id', 'BacSiTruongKhoa_Id', 'BenhVien_Id', 'LyDoChuyenVien_Id', 'ChanDoanICD_Id', 'ChanDoan', 'NgayChuyen', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'DauHieuLamSang', 'TinhTrang', 'NguoiDuaDi', 'PhuongTien', 'ChuyenVienBangGiayKhaiSinh', 'ThuocDaDung', 'HinhThucChuyenVien_Id', 'HuongDieuTri', 'TiepNhan_NoiGioiThieu_ID', 'TiepNhan_SoChuyenTuyen', 'TiepNhan_NgayChuyenDen', 'TiepNhan_TuyenChuyen_ID', 'TiepNhan_LyDoChuyenDen_ID', 'TiepNhan_ChanDoan_NGT', 'PhuongTien_ID'];

    List: ChuyenVien[] | undefined;
    ListFilter: ChuyenVien[] | undefined;
    FormData!: ChuyenVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChuyenVien";
    }
}

