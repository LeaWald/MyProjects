import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { LessonListComponent } from './components/lesson-list/lesson-list.component';
import { RegisteredComponent } from './components/registered/registered.component';

export const routes: Routes = [
    { path: '', component: LoginComponent },
    { path: 'lessonList', component: LessonListComponent },
    { path: 'registered', component: RegisteredComponent },
];