cd E:\Projects\WebAppDocker\WebAppDocker
docker build -f ./Dockerfile --force-rm -t multiton/dockerhub:WebAppDocker ..
docker run --name=MyContainerName --rm -p 58817:80 -d multiton/dockerhub:WebAppDocker
docker login -u multiton
docker push multiton/dockerhub:WebAppDocker
docker pull multiton/dockerhub:WebAppDocker

docker container ls -a
docker image list -a

docker stop MyContainerName