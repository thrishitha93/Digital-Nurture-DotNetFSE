# Git HOL 1 - Basic Commands

## Objectives
Learn basic Git commands for version control.

## Tasks

### 1. Initialize a Repository
```bash
git init
```

### 2. Configure Git (if not done)
```bash
git config user.name "Your Name"
git config user.email "your.email@example.com"
```

### 3. Create and Stage Files
- Create new files or modify existing ones
- Stage changes: `git add <filename>` or `git add .`
- View staged changes: `git status`

### 4. Make Your First Commit
```bash
git commit -m "Initial commit: Add project files"
```

### 5. View Commit History
```bash
git log --oneline
```

### 6. View Changes
```bash
git diff
git show <commit-hash>
```

## Practice Files
- `hello.txt` - Sample file to practice with
- Add more files and make multiple commits

## Expected Outcome
✓ Initialized a local Git repository
✓ Made at least 3 commits
✓ Understand git add, commit, and log commands
