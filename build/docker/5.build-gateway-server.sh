#!/bin/sh
#currentDate=`date +%-m%d`
#imageVersion=0.6.$currentDate-alpine
. ./get-version.sh

echo Building mytelegram/mytelegram-gateway-server:$imageVersion
docker build -t mytelegram/mytelegram-gateway-server -f ./Dockerfile-gateway-server ../../source
docker tag mytelegram/mytelegram-gateway-server mytelegram/mytelegram-gateway-server:$imageVersion