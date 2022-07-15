import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UploadFileClient';

  /**
   *
   */
  constructor(private http:HttpClient) {
   

  }
  
  uploadFile=(files:any)=>{
    console.log("Hi");
    
    if(files.length==0){
      return;
    }
    let filetoUpload=<File>files[0];
    const formData=new FormData();
    formData.append('file',filetoUpload,filetoUpload.name)
    this.http.post("https://localhost:44338/api/upload",formData).subscribe(res=>console.log(res),res=>console.log(res));
    //this.http.post("https://functionapp121.azurewebsites.net/api/Function1?code=AuLabSCuTemZ6KZNtMRUZRD8TzAZe3dXVzKSXw4EyEzkAzFuKqqSnA==&ID=Mitali")
  }
}