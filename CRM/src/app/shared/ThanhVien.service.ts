import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThanhVienService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'ID', 'ParentName', 'TaiKhoan', 'Name', 'Email', 'Active'];
    DisplayColumns002: string[] = ['STT', 'ID', 'ParentName', 'TaiKhoan', 'Name', 'Email', 'Active', 'Save'];
    DisplayColumns003: string[] = ['STT', 'ID', 'ParentName', 'TaiKhoan', 'Name', 'Email', 'SortOrder', 'Note', 'Active', 'Save'];

    List: ThanhVien[] | undefined;
    ListFilter: ThanhVien[] | undefined;
    ListFilter001: ThanhVien[] | undefined;
    FormData!: ThanhVien;
    FormDataLogin!: ThanhVien;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThanhVien";
    }
    ComponentGetAllToListAsync(Service: BaseService) {              
        if (this.List) {
            if (this.List.length == 0) {
                this.GetAllToListAsync().subscribe(
                    res => {
                        this.List = (res as any[]).sort((a, b) => (a.SortOrder > b.SortOrder ? 1 : -1));
                        this.ListFilter = this.List;
                        this.ListFilter001 = this.List;
                    },
                    err => {
                    },
                    () => {                        
                    }
                );
            }
            else{            
            }
        }
        else{           
        }
    }
    Filter(searchString: string) {
        if (searchString.length > 0) {
            searchString = searchString.trim();
            searchString = searchString.toLocaleLowerCase();            
            this.ListFilter = this.List.filter((item: any) =>
                (item.Name && item.Name.toLocaleLowerCase().indexOf(searchString) !== -1)
             || (item.Code && item.Code.toLocaleLowerCase().indexOf(searchString) !== -1)
              || (item.TaiKhoan && item.TaiKhoan.toLocaleLowerCase().indexOf(searchString) !== -1));
        }
        else {
            this.ListFilter = this.List;
        }
    }
    Filter001(searchString: string) {
        if (searchString.length > 0) {
            searchString = searchString.trim();
            searchString = searchString.toLocaleLowerCase();            
            this.ListFilter001 = this.List.filter((item: any) =>
                (item.Name && item.Name.toLocaleLowerCase().indexOf(searchString) !== -1)
             || (item.Code && item.Code.toLocaleLowerCase().indexOf(searchString) !== -1)
              || (item.TaiKhoan && item.TaiKhoan.toLocaleLowerCase().indexOf(searchString) !== -1));
        }
        else {
            this.ListFilter001 = this.List;
        }
    }
    GetLogin() {
        this.FormDataLogin = {
        }
        this.FormDataLogin.Name = localStorage.getItem(environment.ThanhVienHoTen);
        var ThanhVienID = localStorage.getItem(environment.ThanhVienID);
        if (ThanhVienID) {
            this.FormDataLogin.ID = Number(ThanhVienID);
        }
       
    }
  
    AuthenticationAsync() {
        let url = this.APIURL + this.Controller + '/AuthenticationAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.FormData));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

