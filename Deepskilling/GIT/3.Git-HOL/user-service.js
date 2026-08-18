// Merging practice file
// This file will be used for merge exercises

class UserService {
  constructor() {
    this.users = [];
  }

  addUser(user) {
    this.users.push(user);
  }

  getUsers() {
    return this.users;
  }
}

module.exports = UserService;
