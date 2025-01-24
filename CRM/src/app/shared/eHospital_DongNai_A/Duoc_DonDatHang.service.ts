import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_DonDatHang } from './Duoc_DonDatHang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_DonDatHangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DonDatHang_Id', 'MaChungTu', 'SoChungTu', 'NgayChungTu', 'LoaiChungTu', 'MucDichDonDatHang_Id', 'KhoLap_Id', 'NguoiLap_Id', 'NguoiLap', 'SoSeri', 'SoHoaDon', 'DienGiai', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'GiaTriVat', 'ThueSuat', 'GiaTriThue', 'TyleChietKhau', 'GiaTriChietKhau', 'TienTe_Id', 'TyGia', 'NhaCungCap_Id', 'NhaNhapKhau_Id', 'HinhThucThanhToan_Id', 'NguonDuoc_Id', 'ChungTuLienQuan_Id', 'DaNhanThuoc', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'DienGiaiNghiepVuPhatSinh', 'DuTru_Id'];

    List: Duoc_DonDatHang[] | undefined;
    ListFilter: Duoc_DonDatHang[] | undefined;
    FormData!: Duoc_DonDatHang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_DonDatHang";
    }
}

