# RinhHackCI2023
## Description
This project is a Creditworthiness Prediction Service implemented using the following technology stack:
* ASP.NET Core Web API: The core of the service responsible for handling HTTP requests and implementing the creditworthiness prediction logic.
* nginx: A web server that acts as a reverse proxy, forwarding requests from clients to the ASP.NET Core Web API.
* PostgreSQL: A relational database used to store user data for creditworthiness analysis.
* Docker and Docker Compose: Containerization tools used to package the application and its dependencies, ensuring consistent deployment across different environments.
* ML.NET: Machine Learning framework for building custom machine learning models. In this project, ML.NET is utilized to predict creditworthiness based on user data.
## Installation
Make sure you have Docker and Docker Compose installed on your system.
1. Clone the repository: `git clone https://github.com/VGA815/RinhHackCI2023.git` `cd RinhHackCI2023`
2. Build and run the Docker containers: `docker-compose up`
3. Access the Creditworthiness Prediction Service at http://localhost:5000.
## Usage
1. Once the service is running, you can make HTTP requests to the API to predict creditworthiness. Example API endpoint: http://localhost/api/Form
