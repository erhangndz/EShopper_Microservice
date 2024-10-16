# EShopper Microservice - E-Commerce Platform

**EShopper Microservice** is a modular and scalable e-commerce platform built with **ASP.NET Core** using microservice architecture. The project implements various services such as catalog, basket, ordering, and messaging, each operating as independent microservices. This architecture allows for scalability, flexibility, and ease of deployment.

## Features

- **Microservices Architecture**: Includes individual services for different aspects of the e-commerce platform such as:
  - **Order Service**
  - **Basket Service**
  - **Catalog Service**
  - **Message Service**
  
- **API Gateway**: Integrates all microservices under a single entry point for client interactions.
  
- **Identity Server**: Provides authentication and authorization across all microservices.

- **Messaging with RabbitMQ**: Implements messaging patterns between services for efficient and decoupled communication.
  
- **Admin and Client Interfaces**: Separate interfaces for admin management and user interaction with the shop.

## Microservices

1. **Order Microservice**:
   - Manages order creation, processing, and history.
   - Exposes REST APIs for order management.

2. **Basket Microservice**:
   - Handles user baskets, allowing items to be added, updated, and removed.
   - Integrates with Redis for session management and high availability.

3. **Catalog Microservice**:
   - Manages product catalog, including CRUD operations for products, categories, and pricing.
   - Uses SQL databases for persistent data storage.

4. **Message Service**:
   - Implements communication between services using RabbitMQ.
   - Includes a message broker to handle asynchronous messaging for various platform events.

## Technology Stack

- **ASP.NET Core 6.0**
- **Entity Framework Core** with SQL Server for persistent storage.
- **RabbitMQ** for messaging between services.
- **Ocelot API Gateway** to route requests to appropriate microservices.
- **Docker** for containerization, enabling scalable and flexible deployments.
- **Swagger** for API documentation.

## Installation

To set up the project locally:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/erhangndz/EShopper_Microservice.git
