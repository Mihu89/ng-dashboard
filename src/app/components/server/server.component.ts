import { Component, Input, OnInit } from '@angular/core';
import { Server } from '../../shared/models/server.model';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent implements OnInit {
  color: string;
  buttonMessage: string;

  @Input() serverInput: Server;

  constructor() { }

  ngOnInit(): void {
    this.setServerStatus(this.serverInput.isOnline);
  }

  toggleStatus(status: boolean){
    console.log(this.serverInput.isOnline);
    this.setServerStatus(!status);
  }

  setServerStatus(isOnline: boolean) {
    if(isOnline){
      this.serverInput.isOnline = true;
      this.color = '#67BC7A';
      this.buttonMessage = "Shut down";
    }else{
      this.serverInput.isOnline = false;
      this.color = '#FF676B';
      this.buttonMessage = "Start";
    }
  }
}
