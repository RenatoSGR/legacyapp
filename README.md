# gh-legacyapp

This is a legacy application that is being migrated to the cloud.

## Prerequisites

- [.NET](https://dotnet.microsoft.com/en-us/download)
- [Node.js](https://nodejs.org/en/)
- [Docker](https://www.docker.com/)

## Running the application

### Album API
To run the albumapi:

```shell
cd containerapps-albumapi-csharp/src
dotnet run
```

### Album UI

Install cross-env:
```shell
npm install --global cross-env
```
Install npm dependencies:

```shell
cd containerapps-albumui/src
npm install
```
Run albumui:
```shell
npm run start
```