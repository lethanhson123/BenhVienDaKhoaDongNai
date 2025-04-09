import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_PhongBan } from './DM_PhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_PhongBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhongBan_Id', 'MaPhongBan', 'TenPhongBan', 'TenPhongBan_En', 'TenPhongBan_Ru', 'LoaiPhongBan_Id', 'Cap', 'CapTren_Id', 'TruongPhong', 'LoaiPhongBenh_Id', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'CoThucHienDichVu', 'Idx', 'QuanLyNhanSu', 'IsKhoaDieuTri', 'IsChuyenKhoa', 'CostCenTer_Id', 'ChuyenKhoa_Id', 'DiaDiemLamViec_Id', 'SiteCode', 'Mapping_Public_Id', 'MaTheoQuiDinh', 'SoThuTuMin', 'SoThuTuMax', 'SoThuTuMin_2', 'SoThuTuMax_2'];
    DisplayColumns002: string[] = ['Save', 'STT', 'PhongBan_Id', 'MaPhongBan', 'TenPhongBan', 'CostCenTer_Id', 'ChuyenKhoa_Id', 'TenKhongDau', 'TamNgung'];
    DisplayColumns003: string[] = ['Save', 'STT', 'PhongBan_Id', 'MaPhongBan', 'TenPhongBan', 'CostCenTer_Id', 'ChuyenKhoa_Id', 'TenKhongDau', 'TamNgung'];
    DisplayColumns004: string[] = ['Save', 'STT', 'PhongBan_Id', 'MaPhongBan', 'TenPhongBan', 'CostCenTer_Id', 'ChuyenKhoa_Id', 'TenKhongDau'];

    List: DM_PhongBan[] | undefined;
    ListFilter: DM_PhongBan[] | undefined;
    FormData!: DM_PhongBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_PhongBan";
    }
    GetByPhongBan_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByPhongBan_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

