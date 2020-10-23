import { Component, OnInit } from '@angular/core';
import { Server } from 'src/app/shared/models/server.model';
const OUR_SERVERS = [
  { id: 1, name: 'dev-server', isOnline: true },
  { id: 2, name: 'mail-server', isOnline: true },
  { id: 3, name: 'qa-server', isOnline: false },
  { id: 4, name: 'prod-server', isOnline: true },
];
@Component({
  selector: 'app-section-health',
  templateUrl: './section-health.component.html',
  styleUrls: ['./section-health.component.css'],
})
export class SectionHealthComponent implements OnInit {
  constructor() {}
  servers: Server[] = OUR_SERVERS;
  ngOnInit(): void {}
}
