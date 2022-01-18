import { Component,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-gentckn',
  templateUrl: './gentckn.component.html'
})
export class GentcknComponent {

  public generatedTCKN: any  = 0;
  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
  }

  generateTCKN() {

    this.http.post('https://localhost:7144/personel/tc',null).subscribe(result => {
      this.generatedTCKN = result;
    }, error => console.error(error));

  }
}
