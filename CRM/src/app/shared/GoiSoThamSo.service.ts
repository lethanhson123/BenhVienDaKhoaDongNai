import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSoThamSo } from 'src/app/shared/GoiSoThamSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoThamSoService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'GoiSoThamSoID', 'DanhMucNgonNguName', 'GoiSoThamSoName'];
    DisplayColumns002: string[] = ['STT', 'ID', 'Name', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'KichThuocChu005', 'SortOrder', 'Active', 'Save'];
    DisplayColumns003: string[] = ['STT', 'ID', 'Name', 'Code', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'Save'];
    DisplayColumns004: string[] = ['STT', 'ID', 'Name', 'Code', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'KichThuocChu005', 'Save'];
    DisplayColumns005: string[] = ['STT', 'ID', 'Name', 'Code', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'KichThuocChu005', 'KichThuocChu006', 'Save'];
    DisplayColumns006: string[] = ['STT', 'ID', 'Name', 'Code', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'KichThuocChu005', 'KichThuocChu006', 'KichThuocChu007', 'Save'];
    DisplayColumns007: string[] = ['STT', 'ID', 'Name', 'Code', 'BuocNhayTiepNhan', 'KichThuocChu001', 'KichThuocChu002', 'KichThuocChu003', 'KichThuocChu004', 'KichThuocChu005', 'KichThuocChu006', 'KichThuocChu007', 'KichThuocChu008', 'HTMLContent', 'Save'];

    List: GoiSoThamSo[] | undefined;
    ListFilter: GoiSoThamSo[] | undefined;
    FormData!: GoiSoThamSo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoThamSo";
    }
    KhoiPhucAsync() {
        let url = this.APIURL + this.Controller + '/KhoiPhucAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

