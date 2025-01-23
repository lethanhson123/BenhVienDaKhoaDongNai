import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysCommandsComponent } from './sys-commands.component';

describe('SysCommandsComponent', () => {
  let component: SysCommandsComponent;
  let fixture: ComponentFixture<SysCommandsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysCommandsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysCommandsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
