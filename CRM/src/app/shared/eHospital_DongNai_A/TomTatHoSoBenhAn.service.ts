import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TomTatHoSoBenhAn } from './TomTatHoSoBenhAn.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TomTatHoSoBenhAnService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TomTatHoSoBenhAn_Id', 'SoPhieuTomTat', 'BenhAn_Id', 'BenhNhan_Id', 'LoaiKCB_Id', 'HoTenCha', 'HoTenMe', 'NguoiGiamHo', 'MaDonVi', 'TenDonVi', 'DiaChiDonVi', 'ChanDoanVaoVien', 'ChanDoanRaVien', 'QuaTrinhBenhLy', 'TomTatKetQua', 'PhuongPhapDieuTri', 'NgaySinhCon', 'NgayConChet', 'SoConChet', 'GhiChu', 'ThuTruongDonVi_Id', 'MaTheTam', 'DuPhong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BenhAnNgoaiTru_Id', 'LanhDaoKhoa_Id', 'NguoiLap_Id'];

    List: TomTatHoSoBenhAn[] | undefined;
    ListFilter: TomTatHoSoBenhAn[] | undefined;
    FormData!: TomTatHoSoBenhAn;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TomTatHoSoBenhAn";
    }
}

