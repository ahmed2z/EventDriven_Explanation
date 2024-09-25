# Event-Driven Console Application: Temperature Monitoring System

## Overview

This is a simple event-driven console application that simulates a **temperature monitoring system**. The program demonstrates the use of **events and delegates** in C#. When the temperature exceeds a predefined threshold, an event is triggered, and the program notifies the user with a warning message.

## Features

- Event-driven mechanism using C# events and delegates.
- Monitors and checks the current temperature.
- Raises an alert when the temperature exceeds a given threshold.

## How It Works

1. **Temperature Sensor**: The `TemperatureSensor` class continuously checks the temperature and raises an event when the temperature exceeds a specified threshold.
   
2. **Subscriber**: The `Subscriber` class listens for the event and handles it by displaying a warning message.

3. **Event Handling**: The application demonstrates how to subscribe to and handle events in a console-based environment.

## Project Structure

- `TemperatureSensor`: This class acts as the **publisher**. It declares an event that is triggered when the temperature crosses a certain limit.
  
- `Subscriber`: This class acts as the **subscriber**. It listens for the event and responds when the event is raised.

- `Program`: The main entry point that initializes the temperature sensor, sets the threshold, subscribes to the event, and simulates temperature readings.

## Getting Started

### Prerequisites

- You need to have **Visual Studio** installed with support for **C# development**.
- **.NET SDK** version 6.0 or later.

### Steps to Run the Application

1. Clone or download this repository to your local machine.
2. Open the project folder in Visual Studio.
3. Run the application:
   - Press `Ctrl + F5` in Visual Studio or run the project using the command line (`dotnet run`).
4. The program will simulate temperature checks and raise an event if the temperature exceeds the defined threshold (30°C in this case).
