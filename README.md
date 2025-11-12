# UserManagementAPI

A simple RESTful API built with .NET for managing user records.  
The API supports creating, retrieving, updating and deleting users (CRUD), includes validation and logging middleware.

## 🚀 Features  
- GET /api/users — retrieve all users  
- GET /api/users/{id} — retrieve a user by ID  
- POST /api/users — create a new user (requires Name and Email)  
- PUT /api/users/{id} — update an existing user  
- DELETE /api/users/{id} — remove a user  
- Logging middleware to log each HTTP request  
- Validation to ensure only valid user data is accepted  

## 🛠️ How to run  
1. Clone the repository:  
   ```bash
   git clone https://github.com/yourusername/UserManagementAPI.git
2. Open the project folder and run:
  dotnet run
3. Navigate to http://localhost:<port>/api/users to test endpoints.

📁 Project Structure
/Controllers
  └── UsersController.cs
/Models
  └── User.cs
/Repositories
  └── UserRepository.cs
Program.cs

✅ Assignment Checklist

GitHub repository created and public
CRUD endpoints implemented
Validation logic included
Logging middleware in place
Debugging assisted by GitHub Copilot
