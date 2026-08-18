# Git HOL 3 - Merging

## Objectives
Learn how to merge branches and integrate code changes.

## Tasks

### 1. Create Feature Branch
```bash
git checkout -b feature/user-profile
```

### 2. Make Changes and Commit
- Add or modify files
- Create multiple commits
```bash
git add .
git commit -m "Add user profile page"
```

### 3. Switch Back to Main
```bash
git checkout main
```

### 4. Merge Feature Branch
```bash
git merge feature/user-profile
```

### 5. Fast-Forward Merge (Linear History)
```bash
git merge --ff feature/simple-fix
```

### 6. No-Fast-Forward Merge (Creates Merge Commit)
```bash
git merge --no-ff feature/new-feature -m "Merge feature/new-feature into main"
```

### 7. View Merge History
```bash
git log --graph --oneline --all
```

### 8. Clean Up Merged Branches
```bash
git branch -d feature/user-profile
```

## Practice Scenarios
1. **Simple Merge**: Create feature → commit → merge to main
2. **Multiple Features**: Create 2-3 feature branches and merge all
3. **Merge Order**: Merge features in different orders and observe history

## Common Merge Strategies
- `--ff` (Fast-forward): Reapply commits
- `--no-ff`: Always create merge commit
- `--squash`: Combine all commits into one

## Expected Outcome
✓ Successfully merged multiple feature branches
✓ Understand fast-forward vs. merge commits
✓ Clean up branches after merging
✓ View merge history with git log
