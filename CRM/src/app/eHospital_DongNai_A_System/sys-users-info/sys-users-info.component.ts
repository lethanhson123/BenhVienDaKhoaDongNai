import { Component, OnInit, ViewChild } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';



import { Sys_Users } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.model';
import { Sys_UsersService } from 'src/app/shared/eHospital_DongNai_A_System/Sys_Users.service';

@Component({
  selector: 'app-sys-users-info',
  templateUrl: './sys-users-info.component.html',
  styleUrls: ['./sys-users-info.component.css']
})
export class SysUsersInfoComponent implements OnInit {

  constructor(
     public ActiveRouter: ActivatedRoute,
     public Router: Router,
     public NotificationService: NotificationService,
     public DownloadService: DownloadService, 
   
     public Sys_UsersService: Sys_UsersService,
     
   ) { }
 
   ngOnInit(): void {
     this.Sys_UsersService.BaseParameter.User_Id = Number(this.ActiveRouter.snapshot.params.ID);
     this.Sys_UsersSearch();
   }
   
   Sys_UsersSearch() {
     this.Sys_UsersService.IsShowLoading = true;
     this.Sys_UsersService.GetByUser_IdAsync().subscribe(
       res => {
         this.Sys_UsersService.FormData = res as Sys_Users;
         if (this.Sys_UsersService.FormData.User_Id == environment.InitializationNumber) {
         }
       },
       err => {
       },
       () => {
         this.Sys_UsersService.IsShowLoading = false;
       }
     );
   }
   Sys_UsersSave() {
     this.Sys_UsersService.IsShowLoading = true;
     this.Sys_UsersService.SaveAsync().subscribe(
       res => {
         this.Sys_UsersService.FormData = res as Sys_Users;
         this.Router.navigateByUrl(environment.SysUsersInfo + this.Sys_UsersService.FormData.User_Id);
         this.NotificationService.warn(environment.SaveSuccess);
       },
       err => {
         this.NotificationService.warn(environment.SaveNotSuccess);
       },
       () => {
         this.Sys_UsersService.IsShowLoading = false;
       }
     );
   }
   
 
 }