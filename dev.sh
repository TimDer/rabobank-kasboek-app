#!/bin/bash

if [ ! -f ./AppRunner ]; then
    git clone https://github.com/TimDer/AppRunner.git AppRunnerSource
    ./AppRunnerSource/build.sh
    cp ./AppRunnerSource/AppRunnerDist/AppRunner ./AppRunner
    chmod +x ./AppRunner
    rm -rf ./AppRunnerSource
fi

./AppRunner -json ./commands.json
