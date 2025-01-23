import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysGroupCommandsComponent } from './sys-group-commands.component';

describe('SysGroupCommandsComponent', () => {
  let component: SysGroupCommandsComponent;
  let fixture: ComponentFixture<SysGroupCommandsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysGroupCommandsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysGroupCommandsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
