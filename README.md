# ServiceBusSend

## Overview
ServiceBusSend is a C# project designed to demonstrate how to send messages to an Azure Service Bus queue. Azure Service Bus is a fully managed enterprise message broker that facilitates the transfer of data between applications and services.

## Prerequisites
- .NET Core SDK installed on your machine
- An active Azure subscription
- Azure Service Bus namespace and queue

## Setup
1. Clone this repository:
   ```sh
   git clone https://github.com/DavElizG/ServiceBusSend.git
   cd ServiceBusSend
   ```

2. Install the required NuGet packages:
   ```sh
   dotnet add package Azure.Messaging.ServiceBus
   ```

3. Configure your Azure Service Bus connection string in the `appsettings.json` file:
   ```json
   {
     "ServiceBusConnectionString": "<Your-Service-Bus-Connection-String>",
     "QueueName": "<Your-Queue-Name>"
   }
   ```

## Usage
1. Build the project:
   ```sh
   dotnet build
   ```

2. Run the project:
   ```sh
   dotnet run
   ```

3. The application will send a message to the specified Azure Service Bus queue.

## Code Overview
- `Program.cs`: The main entry point of the application.
- `ServiceBusSender.cs`: Contains the logic for sending messages to the Azure Service Bus queue.

## Contributing
Feel free to submit issues and pull requests for any improvements or bug fixes.

## License
This project is licensed under the MIT License.
```
