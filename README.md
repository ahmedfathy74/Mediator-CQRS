# Blogging System with C# and .NET Core

This project is a simple blogging system implemented in C# using .NET Core 8. It follows the principles of Clean Architecture and utilizes Mediator pattern along with CQRS (Command Query Responsibility Segregation).

## Introduction

This project aims to provide a platform for users to create, read, update, and delete blog posts, categorized into different categories for better organization. By following Clean Architecture principles, the codebase is structured to be modular, maintainable, and scalable. Mediator pattern and CQRS are employed to achieve loose coupling between components and separation of concerns, resulting in a more robust and testable application.

## Features

- **Posts:** Users can create, read, update, and delete blog posts.
- **Categories:** Posts can be categorized into different categories for easy organization.
- **Clean Architecture:** The project structure follows Clean Architecture principles for better separation of concerns and maintainability.
- **Mediator Pattern:** Mediator pattern is used to decouple the components and promote single responsibility.
- **CQRS:** Command Query Responsibility Segregation pattern is employed for separating read and write operations, improving scalability and performance.

## Technologies Used

- **C#:** The primary programming language used for development.
- **.NET Core 8:** The framework for building cross-platform applications.
- **Entity Framework Core:** ORM used for interacting with the database.
- **MediatR:** Library for implementing the Mediator pattern.
- **Swagger:** API documentation tool for easy testing and understanding of endpoints.

## Getting Started

### Installation

1. **Clone the repository:**
- https://github.com/ahmedfathy74/Mediator-CQRS.git
2. **Navigate to the project directory:**
  -cd your_project
3. **Run the application:**
  dotnet run
  ### Usage
1. **Access the API documentation:**
-Open http://localhost:5000/swagger/index.html in your web browser.


## Configuration

- Database connection string and other configurations can be found in `appsettings.json` file.
- Ensure that you have the necessary NuGet packages installed.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create your feature branch: `git checkout -b feature/new-feature`.
3. Commit your changes: `git commit -am 'Add new feature'`.
4. Push to the branch: `git push origin feature/new-feature`.
5. Submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- This project was inspired by [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) principles proposed by Uncle Bob.
- Mediator pattern implementation was facilitated by the [MediatR](https://github.com/jbogard/MediatR) library.
