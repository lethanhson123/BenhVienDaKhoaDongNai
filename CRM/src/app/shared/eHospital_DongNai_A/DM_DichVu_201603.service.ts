import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DichVu_201603 } from './DM_DichVu_201603.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DichVu_201603Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DichVu_Id', 'NhomDichVu_Id', 'MaDichVu', 'MaDichVu_Seg01', 'MaDichVu_Seg02', 'MaDichVu_Seg03', 'MaDichVu_Seg04', 'TenDichVu', 'TenDichVu_En', 'TenDichVu_Ru', 'Cap', 'CapTren_Id', 'DonViTinh', 'Idx', 'ChonHetCapDuoi', 'CoGiaDichVu', 'GiaCoDinh', 'ThucHienBenNgoai', 'SoPhim', 'MaQuiDinh', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'CoGiaTriChuan', 'Test', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'NhomDichVu_Report_Local_Id', 'NhomDichVu_Report_Global_Id', 'ShortName', 'InputCode', 'NoResult', 'ApplyFor', 'PrintWhenNull', 'ReportCode', 'ReportTitle', 'DoUuTienDichVu', 'MaMay', 'BHYT', 'IsThongSo', 'CostCenter_Id', 'SiteCode', 'Mapping_Public_Id'];

    List: DM_DichVu_201603[] | undefined;
    ListFilter: DM_DichVu_201603[] | undefined;
    FormData!: DM_DichVu_201603;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DichVu_201603";
    }
}

