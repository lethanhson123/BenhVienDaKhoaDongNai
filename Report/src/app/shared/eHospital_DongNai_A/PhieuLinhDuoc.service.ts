import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuLinhDuoc } from './PhieuLinhDuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuLinhDuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChungTu_Id', 'MaChungTu', 'SoChungTu', 'NgayChungTu', 'LoaiChungTu', 'MucDichChungTu_Id', 'KhoXuat_Id', 'NguoiGiao_Id', 'NguoiGiao', 'KhoNhap_Id', 'NguoiNhan_Id', 'NguoiNhan', 'NguoiKiemTra', 'NguoiDuyet', 'KeToanTruong', 'ThuKho', 'SoSeri', 'SoHoaDon', 'DienGiai', 'GiaTri', 'GiaTriThanhToan', 'TyLeVat', 'GiaTriVat', 'ThueSuat', 'GiaTriThue', 'TyleChietKhau', 'GiaTriChietKhau', 'TienTe_Id', 'TyGia', 'SoChungTuGoc', 'NgayChungTuGoc', 'NhaCungCap_Id', 'HinhThucThanhToan_Id', 'NguonDuoc_Id', 'ChungTuLienQuan_Id', 'ToaThuoc_Id', 'ToaThuocNoiTru_Id', 'BenhAn_Id', 'DaNhanThuoc', 'NguoiNhap_Id', 'NgayNhap', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'PhieuLinh_Id', 'DienGiaiNghiepVuPhatSinh', 'TongHop_TuNgay', 'TongHop_DenNgay', 'CoSo', 'TongHop', 'Phanloaiphieulinh', 'Duyet', 'NgayDuyet', 'ThoiGianDuyet', 'NguoiDuyet_Id', 'LyDo'];

    List: PhieuLinhDuoc[] | undefined;
    ListFilter: PhieuLinhDuoc[] | undefined;
    FormData!: PhieuLinhDuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuLinhDuoc";
    }
}

