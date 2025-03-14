import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysReportsInfoComponent } from './sys-reports-info.component';

describe('SysReportsInfoComponent', () => {
  let component: SysReportsInfoComponent;
  let fixture: ComponentFixture<SysReportsInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysReportsInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysReportsInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
