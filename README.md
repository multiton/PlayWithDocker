## PlayWithDocker (no Compose)

To build docker image from command line﻿, you must be in the Dockerfile folder,  
but still use this syntax (-f ./Dockerfile is mandatory) so:  

1. cd F:\Projects\PureDockerNoCompose\WebAppDocker
2. docker build -f ./Dockerfile --force-rm -t multiton/dockerhub:WebAppDocker ..  

docker run --name=MyContainerName --env=ASPNETCORE_URLS=https://+:443 -p 443:443 multiton/dockerhub:WebAppDocker  

https://localhost/swagger/index.html  

// Save docker-image to file:  
docker save -o f:\temp\dockerimage.tar multiton/dockerhub:WebAppDocker  

docker login -u multiton  
docker push multiton/dockerhub:WebAppDocker  
docker pull multiton/dockerhub:WebAppDocker  

docker container ls -a  
docker image list -a  
docker system prune -a  

docker stop MyContainerName  

docker context ls  

<PropertyGroup>  
	...  
	<DockerfileTag>multiton/dockerhub:WebAppDocker</DockerfileTag>  
</PropertyGroup>  
  
Certificates (pfx-files) location:  
C:\Users\<user-name>\AppData\Roaming\ASP.NET\Https

https://learn.microsoft.com/ru-ru/visualstudio/containers/container-launch-settings?view=vs-2022
