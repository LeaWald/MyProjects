import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private users: any[] = [
    { userName: 'רחל', password: "1234", userPermission: 'teacher' },
    { userName: 'נחמי', password: "5678", userPermission: 'teacher' },
    { userName: 'מרים', password: "6398", userPermission: 'teacher' },
    { userName: 'אביגיל', password: "A789", userPermission: 'teacher' },
    { userName: 'מיכל', password: "abcd", userPermission: 'secretary' },
    { userName: 'רבקה', password: "efgh", userPermission: 'teacher' },
    { userName: 'לאה', password: "L215", userPermission: 'teacher' },
    { userName: 'נועה', password: "ijkl", userPermission: 'secretary' },
    { userName: 'שירה', password: "mnop", userPermission: 'secretary' }
  ];

  constructor() { }
  getUserdetails(): any[] {
    return this.users;
  }
}
