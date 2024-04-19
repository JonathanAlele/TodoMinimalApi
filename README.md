
# TodoMinimalApi  ASP.NET Minimal API with In-Memory Database

This project implements a simple Todo application using ASP.NET Minimal API and an in-memory database. It demonstrates CRUD (Create, Read, Update, Delete) operations for managing Todo items.

## Endpoints are listed below
| `GET /todoitems` | Get all to-do items |
|`GET /todoitems/complete`| Get completed to-do items|
|`GET /todoitems/{id}`|Get an item by ID
|`POST /todoitems`|Add a new item
|`PUT /todoitems/{id}`|Update an existing item
|`DELETE /todoitems/{id}`|Delete an item

Sample POST payload is as follows:
{ "name":"write code", "isComplete":true }
