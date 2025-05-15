import { Component } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef } from 'ag-grid-community';
import { ModuleRegistry, AllCommunityModule } from 'ag-grid-community';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NgIf } from '@angular/common';
import { Router } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';

ModuleRegistry.registerModules([AllCommunityModule]);

@Component({
  selector: 'app-registered',
  standalone: true,
  imports: [AgGridAngular, MatToolbarModule, NgIf, MatButtonModule],
  templateUrl: './registered.component.html',
  styleUrl: './registered.component.css'
})
export class RegisteredComponent {
  constructor(public router: Router) { }
  registered = [
    { firstName: "מרים", lastName: "לוי", phone: "050-1234567", identity: "123456789", lesson: "פילאטיס", price: 500, paid: true },
    { firstName: "שרה", lastName: "כהן", phone: "050-2345678", identity: "987654321", lesson: "עיצוב דינאמי", price: 400, paid: false },
    { firstName: "רחל", lastName: "גולדשטין", phone: "050-3456789", identity: "456789123", lesson: "TRX", price: 700, paid: true },
    { firstName: "אסתר", lastName: "פרידמן", phone: "050-4567890", identity: "321654987", lesson: "יוגה", price: 600, paid: false },
    { firstName: "טובה", lastName: "כץ", phone: "050-5678901", identity: "654321789", lesson: "אקורבטיקה", price: 850, paid: true },
    { firstName: "חוה", lastName: "שוורץ", phone: "050-6789012", identity: "789123456", lesson: "אירובי", price: 550, paid: true },
    { firstName: "לאה", lastName: "מזרחי", phone: "050-7890123", identity: "159753486", lesson: "TRX + עיצוב", price: 400, paid: false },
    { firstName: "נעומי", lastName: "אהרון", phone: "050-8901234", identity: "753159486", lesson: "עיצוב", price: 600, paid: true },
    { firstName: "מלכה", lastName: "זהב", phone: "050-9012345", identity: "852963741", lesson: "פילאטיס", price: 500, paid: false },
    { firstName: "שושנה", lastName: "לוין", phone: "050-0123456", identity: "963852741", lesson: "עיצוב דינאמי", price: 400, paid: true },
    { firstName: "ברכה", lastName: "ריבלין", phone: "050-1234568", identity: "147258369", lesson: "TRX", price: 700, paid: false },
    { firstName: "רבקה", lastName: "שטרן", phone: "050-2345679", identity: "258369147", lesson: "יוגה", price: 600, paid: true },
    { firstName: "יעלי", lastName: "ברק", phone: "050-3456780", identity: "369258147", lesson: "אקורבטיקה", price: 850, paid: false },
    { firstName: "חנה", lastName: "כהן", phone: "050-4567891", identity: "741852963", lesson: "אירובי", price: 550, paid: true },
    { firstName: "ציפי", lastName: "אליאב", phone: "050-5678902", identity: "852741963", lesson: "TRX + עיצוב", price: 400, paid: false },
    { firstName: "מירי", lastName: "פינקל", phone: "050-6789013", identity: "963147852", lesson: "עיצוב", price: 600, paid: true },
    { firstName: "דינה", lastName: "שפירו", phone: "050-7890124", identity: "159753258", lesson: "פילאטיס", price: 500, paid: false },
    { firstName: "נועה", lastName: "קליין", phone: "050-8901235", identity: "753951852", lesson: "עיצוב דינאמי", price: 400, paid: true },
    { firstName: "רות", lastName: "הופמן", phone: "050-9012346", identity: "258147963", lesson: "TRX", price: 700, paid: false },
    { firstName: "שירה", lastName: "צפריר", phone: "050-0123457", identity: "369741258", lesson: "יוגה", price: 600, paid: true },
    { firstName: "אביגיל", lastName: "לוי", phone: "050-1234569", identity: "147369258", lesson: "אקורבטיקה", price: 850, paid: false }
  ];

  colDefs: ColDef[] = [
    {
      headerName: "פרטים",
      cellRenderer: (params: any) => {
        const button = document.createElement('button');
        button.innerText = 'לפרטים';
        button.style.border = '2px solid rgb(210 26 60)';
        button.style.backgroundColor = 'white';
        button.style.color = 'black';
        button.style.padding = '5px 10px';
        button.style.cursor = 'pointer';
        button.addEventListener('click', () => this.showDetails(params.data));
        return button;
      }, width: 188
    },
    {
      field: "paid", headerName: "?האם שולם", cellEditor: 'agCheckboxCellEditor', width: 188, editable: true,
      cellStyle: (params) => {
        return params.value ? null : { backgroundColor: 'rgb(210 26 60)' };
      }
    },
    { field: "price", headerName: "מחיר", filter: 'agNumberColumnFilter', width: 188 },
    { field: "lesson", headerName: "שיעור", filter: "agSetColumnFilter", width: 188 },
    { field: "identity", headerName: "מס' זהות", filter: "agSetColumnFilter", width: 188 },
    { field: "phone", headerName: "טלפון", filter: "agSetColumnFilter", width: 188 },
    { field: "lastName", headerName: "משפחה", filter: "agSetColumnFilter", width: 188 },
    { field: "firstName", headerName: "שם", filter: "agSetColumnFilter", width: 188 }
  ];


  showDetails(data: any) {
    const details = `
    שם פרטי: ${data.firstName}
    שם משפחה: ${data.lastName}
    טלפון: ${data.phone}
    תעודת זהות: ${data.identity}
    שיעור: ${data.lesson}
    מחיר: ${data.price}
    שולם: ${data.paid ? 'כן' : 'לא'}
  `;
    alert(details);
  }
  enterLogin() {
    this.router.navigate(['']);
  }
}
