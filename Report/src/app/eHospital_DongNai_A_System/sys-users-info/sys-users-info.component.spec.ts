import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysUsersInfoComponent } from './sys-users-info.component';

describe('SysUsersInfoComponent', () => {
  let component: SysUsersInfoComponent;
  let fixture: ComponentFixture<SysUsersInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysUsersInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysUsersInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
