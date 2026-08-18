import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.html',
  styleUrls: ['./app.css'],
  imports: [CommonModule]
})
export class App {
  title = 'Question 4 Dashboard';

  stats = [
    { label: 'Projects', value: '24', change: '+12%', accent: 'purple' },
    { label: 'Clients', value: '08', change: '+4%', accent: 'blue' },
    { label: 'Revenue', value: '$48K', change: '+18%', accent: 'green' },
    { label: 'Pending', value: '06', change: '-3%', accent: 'orange' }
  ];

  tasks = [
    { name: 'Design homepage', status: 'In progress', color: 'blue' },
    { name: 'API integration', status: 'Review', color: 'purple' },
    { name: 'QA testing', status: 'Pending', color: 'orange' }
  ];

  activity = [
    { text: 'New user sign-up from Bengaluru', time: '2 hours ago' },
    { text: 'Client approved wireframe', time: '4 hours ago' },
    { text: 'Deployment was successful', time: 'Today' }
  ];
}
