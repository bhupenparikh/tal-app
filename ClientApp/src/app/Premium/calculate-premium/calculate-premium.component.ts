import { Component, Inject, NgModule, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormBuilder, Validators } from '@angular/forms';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormControl, FormGroup, NgForm } from '@angular/forms';


@NgModule({
  imports: [ReactiveFormsModule,
    FormsModule
  ]
})
@Component({
  selector: 'app-calculate-premium',
  templateUrl: './calculate-premium.component.html',
  styleUrls: ['./calculate-premium.component.css']
})
export class CalculatePremiumComponent implements OnInit {
  public premium: string;
  baseUrl: string;
  public premiumForm: FormGroup;

  public data: calculatePremium;



  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, public _fb: FormBuilder) {

    this.baseUrl = baseUrl;
    
   
  }



  ngOnInit() {
    this.premiumForm = this._fb.group({

      name: ['', [Validators.required]],
      age: ['', [Validators.required]],
      occupation: ['', [Validators.required]],
      dob: ['', [Validators.required]],
      deathsum: ['', [Validators.required]]

    })
  }
  
  onSubmit() {
    if (!this.premiumForm.valid) {
      return;
    }

    
    this.http.post(this.baseUrl + 'premium', this.premiumForm.value).subscribe(result => {
      this.premium = result.toString();
      
    }, error => console.error(error));

  }
}
interface calculatePremium {
  name: string;
  age: string;
  occupation: string;
  dob: string;
  deathsum: string;
}
