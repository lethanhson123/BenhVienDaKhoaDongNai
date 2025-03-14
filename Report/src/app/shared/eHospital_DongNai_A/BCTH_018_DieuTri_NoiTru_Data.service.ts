import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BCTH_018_DieuTri_NoiTru_Data } from './BCTH_018_DieuTri_NoiTru_Data.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BCTH_018_DieuTri_NoiTru_DataService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_Id', 'TenKhoa', 'MaPhongBan', 'Thang', 'Nam', 'SoGiuongBenh', 'SoGiuongBenhNu', 'RaKhoa', 'VaoKhoa', 'SoNguoiDauKy', 'SoNguoiDauKyNu', 'NTTongSo', 'NTTongSoNu', 'NTDuoi15Tuoi', 'NTDuoi15TuoiNu', 'NTCapCuu', 'NTCapCuuNu', 'SoNgayDieuTriNoiTru', 'SoNgayDieuTriNoiTruNu', 'TVTongSo', 'TVTongSoNu', 'TVDuoi15Tuoi', 'TVDuoi15TuoiNu', 'TVTruoc24Gio', 'TVTruoc24GioNu', 'NguoiBenhTheBHYT', 'NguoiBenhTheBHYTNu', 'NguoiBenhCuoiKy', 'NguoiBenhCuoiKyNu', 'SoNguoiXuatVien'];

    List: BCTH_018_DieuTri_NoiTru_Data[] | undefined;
    ListFilter: BCTH_018_DieuTri_NoiTru_Data[] | undefined;
    FormData!: BCTH_018_DieuTri_NoiTru_Data;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BCTH_018_DieuTri_NoiTru_Data";
    }
}

