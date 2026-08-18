import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class App {
  title = 'Question 5 - Shop';
  selectedCategory = 'all';
  searchQuery = '';

  categories = ['all', 'electronics', 'fashion', 'home'];

  products = [
    {
      id: 1,
      name: 'Wireless Headphones',
      category: 'electronics',
      price: '$89.99',
      rating: 4.5,
      reviews: 342,
      image: '🎧',
      inStock: true
    },
    {
      id: 2,
      name: 'Smart Watch',
      category: 'electronics',
      price: '$199.99',
      rating: 4.8,
      reviews: 521,
      image: '⌚',
      inStock: true
    },
    {
      id: 3,
      name: 'Designer Sunglasses',
      category: 'fashion',
      price: '$149.99',
      rating: 4.3,
      reviews: 189,
      image: '😎',
      inStock: true
    },
    {
      id: 4,
      name: 'Premium Backpack',
      category: 'fashion',
      price: '$79.99',
      rating: 4.6,
      reviews: 276,
      image: '🎒',
      inStock: true
    },
    {
      id: 5,
      name: 'Coffee Maker',
      category: 'home',
      price: '$129.99',
      rating: 4.4,
      reviews: 412,
      image: '☕',
      inStock: false
    },
    {
      id: 6,
      name: 'LED Desk Lamp',
      category: 'home',
      price: '$45.99',
      rating: 4.7,
      reviews: 634,
      image: '💡',
      inStock: true
    }
  ];

  get filteredProducts() {
    return this.products.filter(p => {
      const categoryMatch = this.selectedCategory === 'all' || p.category === this.selectedCategory;
      const searchMatch = p.name.toLowerCase().includes(this.searchQuery.toLowerCase());
      return categoryMatch && searchMatch;
    });
  }

  selectCategory(cat: string) {
    this.selectedCategory = cat;
  }

  addToCart(product: any) {
    alert(`Added "${product.name}" to cart!`);
  }
}
