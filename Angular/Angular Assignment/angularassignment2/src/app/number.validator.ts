import { AbstractControl, ValidationErrors } from '@angular/forms'

export function number(control: AbstractControl): ValidationErrors | null
{
    const value =+ control.value;

    if(isNaN(value))
    {
        return { 'notANumber': true };
    }
    return null;   
}

