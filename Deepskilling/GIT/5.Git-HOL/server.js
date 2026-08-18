// Main application file for advanced Git operations
// Practice branch management, rebasing, cherry-picking, etc.

const express = require("express");
const app = express();

// Middleware
app.use(express.json());

// Routes
app.get("/", (req, res) => {
  res.json({ message: "Welcome to Git HOL 5!" });
});

app.get("/api/status", (req, res) => {
  res.json({ status: "running" });
});

// Error handling
app.use((err, req, res, next) => {
  console.error(err);
  res.status(500).json({ error: "Internal Server Error" });
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});

module.exports = app;
