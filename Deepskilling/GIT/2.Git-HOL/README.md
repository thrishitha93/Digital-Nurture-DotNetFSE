# Git HOL 2 - Branching

## Objectives
Master Git branching for parallel development.

## Tasks

### 1. Create a New Branch
```bash
git branch feature/new-feature
```

### 2. List All Branches
```bash
git branch -a
```

### 3. Switch to a Branch
```bash
git checkout feature/new-feature
# or (Git 2.23+)
git switch feature/new-feature
```

### 4. Create and Switch in One Command
```bash
git checkout -b feature/another-feature
# or (Git 2.23+)
git switch -c feature/another-feature
```

### 5. Make Changes on the Branch
- Modify files
- Stage and commit changes
- Practice making multiple commits on different branches

### 6. Switch Between Branches
```bash
git checkout main
git checkout feature/new-feature
```

### 7. Delete a Branch
```bash
git branch -d feature/completed-feature
git branch -D feature/force-delete  # Force delete if not merged
```

## Practice Scenario
1. Create `feature/add-login` branch
2. Add login-related files
3. Create `feature/add-database` branch
4. Add database files
5. Switch back and forth between branches
6. Verify each branch has its own commits

## Expected Outcome
✓ Created multiple feature branches
✓ Switched between branches
✓ Each branch contains separate commits
✓ Understand branch isolation
