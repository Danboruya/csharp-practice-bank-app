FROM mcr.microsoft.com/dotnet/sdk:5.0.102-1-buster-slim-amd64

RUN apt update \
  && apt install -y vim

RUN adduser dotnet
WORKDIR /home/dotnet/work
RUN chown -R dotnet:dotnet /home/dotnet/work
USER dotnet

ENV HOME /home/dotnet
COPY .bashrc /home/dotnet/
COPY .vimrc /home/dotnet/