import { Component, signal } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { UsersService } from '../../service/users.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule, MatButtonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  formLogin: FormGroup;
  constructor(public fb: FormBuilder, public usersService: UsersService, public router: Router) {
    this.formLogin = this.fb.group({
      userName: ['', [Validators.required]],
      password: ['', [Validators.required]]
    });
  }
  enter() {
    const users: any[] = this.usersService.getUserdetails();
    const user: any = users.find(u => u.userName == this.formLogin.get('userName')?.value
      && u.password == this.formLogin.get('password')?.value)
    if (!user) {
      alert("שם או סיסמא שגויים")
    }
    else {
      localStorage.setItem("user", user.userPermission)
      if (user.userPermission == "teacher") {
        this.router.navigate(['/lessonList']);
      }
      if (user.userPermission == "secretary") {
        this.router.navigate(['/registered']);
      }
    }
  }
}

