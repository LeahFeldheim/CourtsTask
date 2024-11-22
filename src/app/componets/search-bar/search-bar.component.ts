import { Component, EventEmitter, NgModule, Output } from '@angular/core';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatMenuModule } from '@angular/material/menu';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-search-bar',
  standalone: true,
  imports: [    MatInputModule,
    MatIconModule,
    MatButtonToggleModule,
    MatMenuModule,
    MatButtonModule,FormsModule],
  templateUrl: './search-bar.component.html',
  styleUrl: './search-bar.component.scss'
})
export class SearchBarComponent {
  searchQuery: string = '';
  selectedTabIndex: number = 0;
  @Output() tabChanged = new EventEmitter<number>();
  @Output() serchByEvent = new EventEmitter<string>();



  onTabChange(event: any): void {
    this.selectedTabIndex = +event.value;
   this.tabChanged.emit(this.selectedTabIndex);
  }

  serchBy(){
   this.serchByEvent.emit(this.searchQuery);
  }
}
