import { AbstractControl, ValidationErrors } from '@angular/forms'
 
export function nmchk(control: AbstractControl): 
    ValidationErrors | null {
 
    let nm =+  control.value.length;
    
    console.log(nm);

    if (nm <= 3) {
      return { 'nmchk': true, 'requiredValue': 3 }
    } 

    return null
 
}