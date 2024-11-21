import { Component } from '@angular/core';
import { SearchBarComponent } from './componets/search-bar/search-bar.component';
import { ResultsListComponent } from './componets/results-list/results-list.component';
import { HttpClient, HttpClientModule, HttpHandler } from '@angular/common/http';
import { TikimServiceService } from './Service/tikim-service.service';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ResultsListComponent,HttpClientModule],
  providers:[TikimServiceService,HttpClient ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'בתי דין';
}
