# Git HOL 4 - Conflict Resolution

## Objectives
Learn how to identify, resolve, and prevent merge conflicts.

## Tasks

### 1. Create a Conflict Scenario
```bash
git checkout -b feature/update-config
# Edit config.txt on this branch
git add config.txt
git commit -m "Update config settings"

git checkout main
# Edit the same lines in config.txt differently
git add config.txt
git commit -m "Update config for production"
```

### 2. Attempt to Merge
```bash
git merge feature/update-config
# This will trigger a conflict!
```

### 3. Identify Conflicts
```bash
git status
# Shows conflicted files
```

### 4. Examine Conflict Markers
Files will contain:
```
<<<<<<< HEAD
your main branch changes
=======
feature branch changes
>>>>>>> feature/update-config
```

### 5. Resolve Conflicts
Choose one of:
- **Keep main changes**: Delete feature changes
- **Keep feature changes**: Delete main changes
- **Keep both**: Combine both versions
- **Use tools**: `git checkout --ours` or `git checkout --theirs`

### 6. Complete the Merge
```bash
git add <resolved-file>
git commit -m "Resolve merge conflict in config.txt"
```

### 7. Abort Merge (if needed)
```bash
git merge --abort
```

## Conflict Prevention Strategies
1. **Keep branches short-lived** - Merge frequently
2. **Communicate with team** - Avoid editing same files
3. **Rebase instead of merge** - Linear history
4. **Use merge tools** - GUI tools for complex conflicts

## Tools for Conflict Resolution
- `git mergetool` - Open interactive merge tool
- VS Code - Built-in conflict resolution
- IDE merge tools

## Practice Exercises
1. **Simple Conflict**: Edit same line differently
2. **Multiple Conflicts**: Create conflicts in multiple files
3. **Abort and Retry**: Practice `git merge --abort`

## Expected Outcome
✓ Successfully identified merge conflicts
✓ Resolved conflicts manually
✓ Completed merge after resolution
✓ Understand conflict markers
