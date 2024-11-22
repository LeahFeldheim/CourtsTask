import { Component, OnInit } from '@angular/core';
import { enumStatus, TikModel } from '../../model/tik.model';
import { ResultItemComponent } from '../result-item/result-item.component';
import { MatMenu, MatMenuTrigger } from '@angular/material/menu';
import { TikimServiceService } from '../../Service/tikim-service.service';
import { HttpClient } from '@angular/common/http';
import { SearchBarComponent } from '../search-bar/search-bar.component';
import { UserModel } from '../../model/user.model';

@Component({
  selector: 'app-results-list',
  standalone: true,
  imports: [ResultItemComponent,MatMenu,MatMenuTrigger,SearchBarComponent],
  providers:[HttpClient],
  templateUrl: './results-list.component.html',
  styleUrl: './results-list.component.scss'
})
export class ResultsListComponent implements OnInit {
constructor(private serviceTikIM:TikimServiceService){}
tiklist :TikModel[] = [];
tiklistFilter :TikModel[] = [];
user: UserModel = new UserModel();
ngOnInit(): void {
   this.user = new UserModel()
  this.serviceTikIM.getTikimFromDB().subscribe(x=>{
    this.tiklist = x;
    this.tiklistFilter = x;
  })
}

sortBy(type:number){
  if(type == 1){
    this.tiklist.sort((a, b) => {
      if (a.misTik < a.misTik) return -1;
      if (a.misTik > a.misTik) return 1;
      return 0;
    });
  }
  if(type == 0){
    this.tiklist.sort((a, b) => {
      const dateA = new Date(a.tarichPtichatTik);
      const dateB = new Date(b.tarichPtichatTik);
      return dateA.getTime() - dateB.getTime();
    });
  }
}
tabchange(event:any){
switch(event){
  case 0:this.tiklist = this.tiklistFilter;break;
  case 1: this.tiklist = this.tiklistFilter.filter(x=>x.yprVaada == this.user.userName);break;
  case 2:this.tiklist = this.tiklistFilter.filter(x=>x.status == enumStatus.paail);break;
  case 3:this.tiklist = this.tiklistFilter.filter(x=>x.status == enumStatus.sagur);break;
}
}
serchBy(event:string){
 this.tiklist =  this.tiklistFilter.filter( x=>x.misTik == +event || x.mgishArar.includes( event ));
}
}
