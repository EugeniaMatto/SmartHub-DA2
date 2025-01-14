import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AddDeviceDialogComponent } from './add-device-dialog.component';

describe('AddDeviceDialogComponent', () => {
  let component: AddDeviceDialogComponent;
  let fixture: ComponentFixture<AddDeviceDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddDeviceDialogComponent]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddDeviceDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
