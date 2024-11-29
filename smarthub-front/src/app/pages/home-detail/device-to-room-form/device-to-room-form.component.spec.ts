import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeviceToRoomFormComponent } from './device-to-room-form.component';

describe('DeviceToRoomFormComponent', () => {
  let component: DeviceToRoomFormComponent;
  let fixture: ComponentFixture<DeviceToRoomFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DeviceToRoomFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeviceToRoomFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
