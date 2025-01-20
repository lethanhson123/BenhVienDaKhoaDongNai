import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysGroupMenusComponent } from './sys-group-menus.component';

describe('SysGroupMenusComponent', () => {
  let component: SysGroupMenusComponent;
  let fixture: ComponentFixture<SysGroupMenusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysGroupMenusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysGroupMenusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
