import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrucBanNhatKyComponent } from './truc-ban-nhat-ky.component';

describe('TrucBanNhatKyComponent', () => {
  let component: TrucBanNhatKyComponent;
  let fixture: ComponentFixture<TrucBanNhatKyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrucBanNhatKyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TrucBanNhatKyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
