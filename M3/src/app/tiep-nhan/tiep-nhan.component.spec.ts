import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TiepNhanComponent } from './tiep-nhan.component';

describe('TiepNhanComponent', () => {
  let component: TiepNhanComponent;
  let fixture: ComponentFixture<TiepNhanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TiepNhanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TiepNhanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
