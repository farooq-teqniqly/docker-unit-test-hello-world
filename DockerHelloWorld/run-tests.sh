#!/bin/bash
set -eu -o pipefail

cd DockerHelloWorld
dotnet restore
dotnet watch --project Lib.Tests/Lib.Tests.csproj test