import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysUsersInfo001Component } from './sys-users-info001.component';

describe('SysUsersInfo001Component', () => {
  let component: SysUsersInfo001Component;
  let fixture: ComponentFixture<SysUsersInfo001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysUsersInfo001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysUsersInfo001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
