#Image 
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
#Set the working directoy
WORKDIR /app
#Copy the app to the container
COPY src/app .
#Start the app 
ENTRYPOINT [ "dotnet", "AspNetApp.dll" ]