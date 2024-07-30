# Andromeda ASP.NET Core API

Welcome to the Andromeda ASP.NET Core API! This project serves as the backend for Andromeda, a social media platform. It provides a set of RESTful endpoints to manage users, friendships, posts, likes, comments, tags, notifications, products, product likes, product comments, product tags, chats, and messages. The API uses JWT for authentication and PostgreSQL as the database.

## Table of Contents

- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/andromeda-asp-api.git
   ```
2. Navigate to the project directory:
   ```sh
   cd andromeda-asp-api
   ```
3. Install dependencies:
   ```sh
   dotnet restore
   ```
4. Set up your PostgreSQL database and update the connection string in `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=andromeda_asp;Username=postgres;Password=password"
     }
   }
   ```
5. Apply migrations and update the database:
   ```sh
   dotnet ef database update
   ```
6. Run the application:
   ```sh
   dotnet run
   ```

## Usage

After running the application, the API will be available at `http://localhost:5000/api`.

You can use tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/) to test the endpoints.

### Example Request

To register a new user:
```sh
curl -X POST http://localhost:5000/api/users -H "Content-Type: application/json" -d '{
  "username": "testuser",
  "email": "testuser@example.com",
  "password": "P@ssw0rd"
}'
```

## API Endpoints

### User Endpoints

- `GET /api/users`: Get all users
- `GET /api/users/{id}`: Get user by ID
- `POST /api/users`: Create a new user
- `PUT /api/users/{id}`: Update an existing user
- `DELETE /api/users/{id}`: Delete a user

### Authentication Endpoints

- `POST /api/auth/login`: Login and get a JWT token

### Friendship Endpoints

- `GET /api/friendships`: Get all friendships
- `GET /api/friendships/{id}`: Get friendship by ID
- `POST /api/friendships`: Create a new friendship
- `PUT /api/friendships/{id}`: Update an existing friendship
- `DELETE /api/friendships/{id}`: Delete a friendship

### Post Endpoints

- `GET /api/posts`: Get all posts
- `GET /api/posts/{id}`: Get post by ID
- `POST /api/posts`: Create a new post
- `PUT /api/posts/{id}`: Update an existing post
- `DELETE /api/posts/{id}`: Delete a post

### Like Endpoints

- `GET /api/likes`: Get all likes
- `GET /api/likes/{id}`: Get like by ID
- `POST /api/likes`: Create a new like
- `PUT /api/likes/{id}`: Update an existing like
- `DELETE /api/likes/{id}`: Delete a like

### Comment Endpoints

- `GET /api/comments`: Get all comments
- `GET /api/comments/{id}`: Get comment by ID
- `POST /api/comments`: Create a new comment
- `PUT /api/comments/{id}`: Update an existing comment
- `DELETE /api/comments/{id}`: Delete a comment

### Tag Endpoints

- `GET /api/tags`: Get all tags
- `GET /api/tags/{name}`: Get tag by name
- `POST /api/tags`: Create a new tag
- `PUT /api/tags/{name}`: Update an existing tag
- `DELETE /api/tags/{name}`: Delete a tag

### Notification Endpoints

- `GET /api/notifications`: Get all notifications
- `GET /api/notifications/{id}`: Get notification by ID
- `POST /api/notifications`: Create a new notification
- `PUT /api/notifications/{id}`: Update an existing notification
- `DELETE /api/notifications/{id}`: Delete a notification

### Product Endpoints

- `GET /api/products`: Get all products
- `GET /api/products/{id}`: Get product by ID
- `POST /api/products`: Create a new product
- `PUT /api/products/{id}`: Update an existing product
- `DELETE /api/products/{id}`: Delete a product

### Product Like Endpoints

- `GET /api/productLikes`: Get all product likes
- `GET /api/productLikes/{id}`: Get product like by ID
- `POST /api/productLikes`: Create a new product like
- `PUT /api/productLikes/{id}`: Update an existing product like
- `DELETE /api/productLikes/{id}`: Delete a product like

### Product Comment Endpoints

- `GET /api/productComments`: Get all product comments
- `GET /api/productComments/{id}`: Get product comment by ID
- `POST /api/productComments`: Create a new product comment
- `PUT /api/productComments/{id}`: Update an existing product comment
- `DELETE /api/productComments/{id}`: Delete a product comment

### Product Tag Endpoints

- `GET /api/productTags`: Get all product tags
- `GET /api/productTags/{id}`: Get product tag by ID
- `POST /api/productTags`: Create a new product tag
- `PUT /api/productTags/{id}`: Update an existing product tag
- `DELETE /api/productTags/{id}`: Delete a product tag

### Chat Endpoints

- `GET /api/chats`: Get all chats
- `GET /api/chats/{id}`: Get chat by ID
- `POST /api/chats`: Create a new chat
- `PUT /api/chats/{id}`: Update an existing chat
- `DELETE /api/chats/{id}`: Delete a chat

### Message Endpoints

- `GET /api/messages`: Get all messages
- `GET /api/messages/{id}`: Get message by ID
- `POST /api/messages`: Create a new message
- `PUT /api/messages/{id}`: Update an existing message
- `DELETE /api/messages/{id}`: Delete a message

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

---

Thank you for using Andromeda ASP.NET Core API! If you have any questions or suggestions, please feel free to open an issue or contact the project maintainers. Happy coding!
