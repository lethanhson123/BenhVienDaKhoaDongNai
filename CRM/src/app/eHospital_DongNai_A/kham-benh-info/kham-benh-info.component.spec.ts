import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhInfoComponent } from './kham-benh-info.component';

describe('KhamBenhInfoComponent', () => {
  let component: KhamBenhInfoComponent;
  let fixture: ComponentFixture<KhamBenhInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
