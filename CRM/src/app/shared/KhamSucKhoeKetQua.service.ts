import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamSucKhoeKetQua } from 'src/app/shared/KhamSucKhoeKetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamSucKhoeKetQuaService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'SoThe', 'HoTen', 'GioiTinh', 'BoPhan', 'NgaySinh', 'PhanLoaiSucKhoe', 'ChieuCao', 'CanNang', 'Mach', 'HuyetAp', 'Noi', 'Ngoai', 'Mat', 'TaiMuiHong', 'RangHamMat', 'LamSang', 'PhuSanTienSu', 'PhuSanKhamLamSang', 'PhuSanPAPSMEAR', 'SieuAmTong', 'SieuAmPhuKhoa', 'SieuAmTuyenVu', 'ViemGanSieuViA', 'ViemGanSieuViE', 'HBsAb', 'HbA1C', 'CystatineC', 'Glucose', 'CHO', 'TRI', 'HDL', 'LDL', 'TPT', 'TeBaoMauNgoaiVi', 'XQuangPhoi', 'CanLamSangLamThem'];
    DisplayColumns002: string[] = ['STT', 'ID', 'SoThe', 'HoTen', 'GioiTinh', 'BoPhan', 'NgaySinh', 'PhanLoaiSucKhoe', 'ChieuCao', 'CanNang', 'Mach', 'HuyetAp', 'Noi', 'Ngoai', 'Mat', 'TaiMuiHong', 'RangHamMat', 'LamSang', 'PhuSanTienSu', 'PhuSanKhamLamSang', 'PhuSanPAPSMEAR', 'SieuAmTongQuat', 'SieuAmPhuKhoa', 'SieuAmTuyenVu', 'ViemGanSieuViA', 'ViemGanSieuViE', 'HBsAb', 'HbA1C', 'CystatineC', 'Glucose', 'CHO', 'TRI', 'HDL', 'LDL', 'TPT', 'TeBaoMauNgoaiVi', 'XQuangPhoi', 'CanLamSangLamThem', 'Save'];
    List: KhamSucKhoeKetQua[] | undefined;
    ListFilter: KhamSucKhoeKetQua[] | undefined;
    FormData!: KhamSucKhoeKetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamSucKhoeKetQua";
    }
    SaveListByExcelFileAsync() {
        var lastUpdatedMembershipID = localStorage.getItem(environment.ThanhVienID);
        if (lastUpdatedMembershipID) {
            this.BaseParameter.ThanhVienID = Number(lastUpdatedMembershipID);
        }
        this.BaseParameter.Active = true;
        let url = this.APIURL + this.Controller + '/SaveListByExcelFileAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        if (this.FileToUpload) {
            if (this.FileToUpload.length > 0) {
                for (var i = 0; i < this.FileToUpload.length; i++) {
                    formUpload.append('file[]', this.FileToUpload[i]);
                }
            }
        }
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

