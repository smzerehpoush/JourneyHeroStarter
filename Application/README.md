this project uses Onion Architecture and DDD (Domain Driven Design) with CQRS and ES(Event Sourcing) with a simple
example on how to use all this architecture together from the Controller until the Repository class using Domain
objects and different patterns.

### Documentation of technologies we use
You can find information about this template in:

- [Main Architecture](docs/ARCHITECTURE.md)
- [Hexagonal Architecture](docs/HEXAGONAL.md)
- [DDD](docs/DDD.md)
- [CQRS AND ES](docs/CQRS-ES.md)
- [SOLID](docs/SOLID.md)

### Structure 
this project contains three main directories called `core, infrastructure and presentation`

- **core**: This directory contains two other projects called `Application and Domain`
  - **Application**: In Application layer we have `commands, queries, application services and so on`. also our DTOs live here.
  - **Domain**: This is our domain layer. contains our `domain models, rules, exceptions and repositories`
- **infrastructure**: This directory contains two other projects called `Infrastructure and Persistence`
  - **Infrastructure**: This is our infrastructure layer that contains our settings for infrastructure of project e.g. `logging, IO and so on`
  - **Persistence**: This  is our persistence layer that contains our `Entity Type Configurations, migrations, repository implementations and so on`
- **presentation**: this is our presentation layer that contains our `Controllers, Middlewares and so on`
