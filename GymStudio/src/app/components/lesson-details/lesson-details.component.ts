import { NgIf } from '@angular/common';
import { Component, Input } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-lesson-details',
  standalone: true,
  imports: [NgIf,MatIconModule],
  templateUrl: './lesson-details.component.html',
  styleUrl: './lesson-details.component.css'
})
export class LessonDetailsComponent {
  @Input() dLesson!: any;
  closePopup() {
    this.dLesson = null;
  }
 
}
