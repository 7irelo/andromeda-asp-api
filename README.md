# Andromeda ASP.NET Core API

## Overview

**Andromeda ASP.NET Core API** is a social media API backend where users can share pictures and videos, and chat with their family and friends. This project is built using ASP.NET Core.

## Features

### User Features
- **User Registration and Authentication**: Secure user sign-up and login.
- **Profile Management**: Create and manage user profiles.
- **Media Sharing (Photos and Videos)**: Upload and share multimedia content.
- **News Feed**: Display posts from followed users.
- **Likes, Comments, and Sharing**: Engage with content.
- **Instant Messaging and Group Chats**: Real-time communication.
- **Notifications**: Stay updated with app activities.
- **Search and Discovery**: Find users and content.
- **Privacy and Security Settings**: Control visibility and data security.

### Technical Features
- **ASP.NET Core**: Backend framework for building web APIs.
- **SQL Server**: Relational database management system.
- **RESTful API**: Standard for API communication.
- **JWT Authentication**: Secure user authentication and authorization.

## Prerequisites

- **.NET 6.0 SDK**
- **SQL Server 2019+**

## Getting Started

### Backend Setup

1. **Clone the repository**:
    ```bash
    git clone https://github.com/7irelo/andromeda-asp-api.git
    cd andromeda-web/server
    ```

2. **Install the dependencies**:
    ```bash
    dotnet restore
    ```

3. **Setup SQL Server database**:
    - Create a new SQL Server database named `andromeda`.
    - Update `appsettings.json` with your SQL Server credentials.

4. **Apply migrations**:
    ```bash
    dotnet ef database update
    ```

5. **Create a superuser**:
    ```bash
    dotnet run CreateSuperUser
    ```

6. **Start the server**:
    ```bash
    dotnet run
    ```

### Running the Application

- The ASP.NET Core backend runs at `http://localhost:5000`.

## Project Structure

```
andromeda-asp/
├── Controllers/
├── Data/
├── Models/
├── Services/
├── Program.cs
└── Startup.cs
```

## Contributing

We welcome contributions from the community. Please follow these steps to contribute:

1. **Fork the repository**.
2. **Create a new branch**:
    ```bash
    git checkout -b feature-branch
    ```
3. **Make your changes**.
4. **Commit your changes**:
    ```bash
    git commit -m 'Add some feature'
    ```
5. **Push to the branch**:
    ```bash
    git push origin feature-branch
    ```
6. **Open a pull request**.

Please ensure your code adheres to the project's coding standards and includes appropriate tests.

## Issues and Bug Reports

If you encounter any issues or bugs, please report them on our [Issue Tracker](https://github.com/7irelo/andromeda-asp-api/issues).

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For any queries or support, please contact us at tirelo.eric@gmail.com.

---

Thank you for contributing to Andromeda! We hope this project helps you create a fantastic social media application.
