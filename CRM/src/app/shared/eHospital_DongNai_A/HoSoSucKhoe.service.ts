import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe } from './HoSoSucKhoe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoSoSucKhoe_Id', 'BenhNhan_Id', 'SoHoSoSucKhoe', 'KyHieuDonViCongTac', 'NhomBenhQuanLy_Id', 'NhomBenhQuanLy_Code', 'NgayLapHoSo', 'NguoiLapHoSo_Id', 'NgheNghiep_Id', 'TinhChatNgheNghiep', 'NgheNghiepCu', 'NgheNghiepCu_TuNgay', 'NgheNghiepCu_DenNgay', 'TrinhDo_Id', 'ChucVu_Id', 'LuongChinh', 'NgayVaoBienChe', 'NgayBatDauLamViec', 'BenhSu', 'TienSuDiUng', 'TienSuThuocLa', 'DiaChi', 'CachXaNoiLam', 'CoGiaDinh', 'SoCon', 'SoNguoiTrongGiaDinh', 'ThuNhapBinhQuan', 'NhaLoai', 'DienTichDauNguoi', 'BenhTruyenNhiem', 'BenhXaHoi', 'BenhGiaDinh', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: HoSoSucKhoe[] | undefined;
    ListFilter: HoSoSucKhoe[] | undefined;
    FormData!: HoSoSucKhoe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe";
    }
}

