import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Duoc_DuTru } from './Duoc_DuTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Duoc_DuTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuTru_Id', 'MaChungTu', 'SoChungTu', 'NgayChungTu', 'NgayBaoCao', 'MucDichChungTu_Id', 'KhoNhap_Id', 'NguoiNhan_Id', 'NguoiNhan', 'LoaiVatTu_Id', 'NhomLoaiDuoc_Id', 'TonKhoDauKy', 'TongHop_TuNgay', 'TongHop_DenNgay', 'DienGiai', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'GiaTriVat', 'TienTe_Id', 'TyGia', 'NhaCungCap_Id', 'DonViGiao_Id', 'NguonDuoc_Id', 'ChungTuLienQuan_Id', 'NguoiNhap_Id', 'NgayNhap', 'TrangThai', 'DienGiaiNghiepVuPhatSinh', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: Duoc_DuTru[] | undefined;
    ListFilter: Duoc_DuTru[] | undefined;
    FormData!: Duoc_DuTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Duoc_DuTru";
    }
}

