"# Git HOL 5 - Branch Cleanup & Advanced Operations

## Objectives
Learn to manage branches, clean up repository, and perform advanced Git operations.

## Tasks

### 1. Create Multiple Branches
```bash
git checkout -b feature/auth
git checkout -b feature/api
git checkout -b feature/ui
git checkout -b bugfix/login-error
git checkout -b hotfix/critical-fix
```

### 2. List All Branches
```bash
git branch -a              # List local and remote
git branch -v              # Show last commit on each
git branch --merged        # Show merged branches
git branch --no-merged     # Show unmerged branches
```

### 3. Delete Merged Branches
```bash
git branch -d feature/auth          # Delete after merge
git branch -D feature/auth          # Force delete (unmerged)
```

### 4. Rename Branches
```bash
git branch -m old-name new-name     # Rename branch
git branch -m new-name              # Rename current branch
```

### 5. Clean Up Local Branches
```bash
# Delete all merged branches at once
git branch --merged | grep -v "^*" | xargs git branch -d

# For Windows (PowerShell)
git branch --merged | % {$_.trim()} | ? {$_ -ne "*"} | % {git branch -d $_}
```

### 6. Prune Remote Tracking Branches
```bash
git remote prune origin              # Remove deleted remote branches
git fetch --prune                    # Fetch and remove stale references
```

### 7. View Branch History
```bash
git log --oneline --graph --all --decorate
git log --all --graph --decorate --oneline
```

### 8. Stash Changes (Save Work Temporarily)
```bash
git stash                    # Save uncommitted changes
git stash list               # View all stashes
git stash apply              # Apply latest stash
git stash apply stash@{0}    # Apply specific stash
git stash drop               # Delete a stash
```

### 9. Cherry-pick Commits
```bash
git cherry-pick <commit-hash>        # Apply specific commit to current branch
git cherry-pick <hash1> <hash2>      # Apply multiple commits
```

### 10. Rebase Instead of Merge
```bash
git rebase main                      # Reapply commits on top of main
git rebase -i HEAD~3                 # Interactive rebase last 3 commits
```

## Repository Maintenance
```bash
git gc                               # Garbage collection
git fsck                             # Check repository integrity
git reflog                           # View reference logs
```

## Practice Scenarios

### Scenario 1: Clean Repository
1. Create 5-6 feature branches
2. Merge 3-4 of them
3. Delete merged branches
4. View clean history

### Scenario 2: Stash and Pop
1. Make changes on one branch
2. Stash them before switching
3. Switch to another branch
4. Pop stash back on original branch

### Scenario 3: Cherry-pick
1. Create commit on `feature/x`
2. Checkout `feature/y`
3. Cherry-pick the commit from feature/x
4. Verify commit appears in both branches

### Scenario 4: Rebase
1. Create feature branch from old commit
2. Main has moved forward
3. Rebase feature to latest main
4. View linear history

## Best Practices
✓ Delete branches after merging
✓ Use descriptive branch names: `feature/`, `bugfix/`, `hotfix/`
✓ Keep main branch clean and stable
✓ Regularly prune remote branches
✓ Use `.gitignore` to prevent tracking unnecessary files
✓ Write meaningful commit messages

## Expected Outcome
✓ Effectively manage multiple branches
✓ Clean up repository regularly
✓ Understand stashing and cherry-picking
✓ Maintain clean commit history
✓ Know when to rebase vs. merge
"  
