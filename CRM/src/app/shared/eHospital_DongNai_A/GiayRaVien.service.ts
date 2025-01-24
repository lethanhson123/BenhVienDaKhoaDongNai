import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GiayRaVien } from './GiayRaVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GiayRaVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GiayRaVien_Id', 'SoPhieuRaVien', 'BenhAn_Id', 'BenhNhan_Id', 'ChanDoanRaVien', 'PhuongPhapDieuTri', 'DinhChiThaiNghen', 'DinhChiThaiNghen_NguyenNhan', 'DinhChiThaiNghen_TuoiThai', 'DinhChiThaiNghen_ThoiGian', 'SoBHXHCha', 'HoTenCha', 'SoBHXHMe', 'HoTenMe', 'MaTheTam', 'ThuTruongDonVi_Id', 'LanhDaoKhoa_Id', 'SoNgayNghi', 'NghiTuNgay', 'NghiDenNgay', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoSeri', 'BenhAnNgoaiTru_Id'];

    List: GiayRaVien[] | undefined;
    ListFilter: GiayRaVien[] | undefined;
    FormData!: GiayRaVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GiayRaVien";
    }
}

