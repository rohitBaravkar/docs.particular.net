---
title: SQL Server Transport
summary: A simple send and receive scenario with the SQL Server Transport.
reviewed: 2016-04-27
component: SqlServer
tags:
- SQL Server
related:
- nservicebus/sqlserver
---


## Prerequisites

 1. Ensure an instance SQL Server Express installed and accessible as `.\SQLEXPRESS`. Create a database `SqlServerSimple`.


## Running the project

 1. Start the both the Sender and Receiver projects
 1. At startup Sender will send a message to Receiver.
 1. Receiver will handle the message.


## Core Walk-through


### Configure the SQL Server Transport

snippet: TransportConfiguration