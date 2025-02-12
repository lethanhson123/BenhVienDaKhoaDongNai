import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { QuanLyCongViec } from 'src/app/shared/QuanLyCongViec.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class QuanLyCongViecService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'QuanLyCongViecID', 'DanhMucNgonNguName', 'QuanLyCongViecName'];

    DisplayColumns002: string[] = ['STT', 'NgayGhiNhan', 'NgayDuyet', 'NgayHetHan', 'ParentID', 'ThanhVienID', 'PhanLoai', 'TienDo', 'Code', 'Name', 'XuLy', 'Save'];

    List: QuanLyCongViec[] | undefined;
    ListFilter: QuanLyCongViec[] | undefined;
    FormData!: QuanLyCongViec;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "QuanLyCongViec";
    }
    SearchAll(sort: MatSort, paginator: MatPaginator) {
        if (this.BaseParameter.SearchString.length > 0) {
            this.BaseParameter.SearchString = this.BaseParameter.SearchString.trim();
            if (this.DataSource) {
                this.DataSource.filter = this.BaseParameter.SearchString.toLowerCase();
            }
        }
        else {
            this.ComponentGetAllAndEmptyToListAsync(sort, paginator);
        }
    }
    ComponentGetAllAndEmptyToListAsync(sort: MatSort, paginator: MatPaginator) {
        this.IsShowLoading = true;
        this.GetAllAndEmptyToListAsync().subscribe(
            res => {
                this.List = (res as any[]).sort((a, b) => (a.NgayGhiNhan < b.NgayGhiNhan ? 1 : -1));
                this.ListFilter = this.List.filter(item => item.ID > 0);
                this.DataSource = new MatTableDataSource(this.List);
                this.DataSource.sort = sort;
                this.DataSource.paginator = paginator;
            },
            err => {
            },
            () => {
                this.IsShowLoading = false;
            }
        );
    }
}

