import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysMenusComponent } from './sys-menus.component';

describe('SysMenusComponent', () => {
  let component: SysMenusComponent;
  let fixture: ComponentFixture<SysMenusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysMenusComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysMenusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
