# Trading Engine
This is a generic microservices based trading engine designed to be able to be plugged into any exchange with minimal configuration.   

## Goals ##
There are several goals to this project: primary goal of this project is to be scalable to over 1m TPS in production while using containers with non-scaled versions of the same technology in development/staging environments.
 - At least 1 million TPS (Transactions Per Second) in production.
 - Same architecture in dev, except containerized with lower scalability for cost savings.
 - Entire stack needs to be benchmarkable with load monitoring at all points in time to avoid bottlenecks and downtime.
 - Plug-and-play API for usage.

## Design ## 
The engine will cost of three micro-services:
 - Order Matching Service
 - Market Price Service
 - History Service
 
There will also be three data services:
 - MSSQL
 - Redis
 - Kafka

I'll make a chart for how these interact in the near future.

## Benchmarks ##
TBD
