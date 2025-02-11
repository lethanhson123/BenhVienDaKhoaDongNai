import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysAppSettingsComponent } from './sys-app-settings.component';

describe('SysAppSettingsComponent', () => {
  let component: SysAppSettingsComponent;
  let fixture: ComponentFixture<SysAppSettingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysAppSettingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysAppSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
